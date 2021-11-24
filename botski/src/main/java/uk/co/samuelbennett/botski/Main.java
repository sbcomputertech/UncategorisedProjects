package uk.co.samuelbennett.botski;

import net.dv8tion.jda.api.*;
import net.dv8tion.jda.api.events.message.MessageReceivedEvent;
import net.dv8tion.jda.api.events.message.react.MessageReactionAddEvent;
import net.dv8tion.jda.api.hooks.*;
import net.dv8tion.jda.api.requests.restaction.MessageAction;
import org.jetbrains.annotations.NotNull;
import javax.security.auth.login.LoginException;
import java.awt.Color;
import java.util.*;

// oauth link: https://discord.com/api/oauth2/authorize?client_id=908403697111949403&permissions=84032&scope=bot

public class Main extends ListenerAdapter {
    private static Properties prop;
    private int numTickReactions = 0;
    private String pollMessgaeId = "";
    private int numUpReactions = 0;
    private int numDownReactions = 0;
    public static void main(String[] args) throws LoginException {
        prop = PropReader.readProps();
        assert prop != null;
        String token = prop.getProperty("token");
        JDABuilder.createDefault(token)
                .addEventListeners(new Main())
                .build();
    }

    @Override
    public void onMessageReceived(@NotNull MessageReceivedEvent event) {
        if (event.getAuthor().isBot()) {return;}
        String message = event.getMessage().getContentRaw();
        if (message.startsWith(prop.getProperty("prefix")) || message.startsWith(prop.getProperty("backupPrefix"))) {
            System.out.println("Message received from: " + event.getAuthor() + ". It says: " + event.getMessage().getContentDisplay());
            String[] cargs = message.replace(prop.getProperty("prefix").toCharArray()[0], ' ').replace(prop.getProperty("backupPrefix").toCharArray()[0], ' ').strip().toLowerCase(Locale.ROOT).split(" ");
            String command = cargs[0];
            String[] args = Arrays.copyOfRange(cargs, 1, cargs.length);
            switch (command) {
                default:
                    send("Unrecognised command: " + command, event);
                    break;
                case "ping":
                    send("Pong!", event);
                    break;
                case "meow":
                    send("Meow to you too!", event);
                    break;
                case "whodis":
                    EmbedBuilder whodis = new EmbedBuilder()
                            .setTitle("Who am I???")
                            .setColor(new Color(255, 0, 255))
                            .addBlankField(false)
                            .addField("Am I a person?", "No, I am a robot made by @reddust9", true)
                            .addField("Should I exist?", "Well, @reddust9 clearly thinks so", true)
                            .addField("Why do I exist?", "Because @reddust9 was very, very bored one saturday morning", true)
                            .addBlankField(false)
                            .setThumbnail("https://discord.bots.gg/img/bot_icon_placeholder.png")
                            .setFooter("Thak you for listening. For a command list, use [prefix]commands");
                    sendEmbed(whodis, event);
                    break;
                case "commands":
                    EmbedBuilder commands = new EmbedBuilder()
                            .setTitle("Botski command list")
                            .setColor(new Color(255, 0, 255))
                            .addField("The official command list for Botski", "Made by @reddust9\nThe & character stands for the prefix that you configured for your Botski (it is also the default prefix)", false)
                            .addField("", "Note: all commands are case-insenstiive except arguments\nNote 2: If you lose the prefix, or something happens (see &prefixinfo) and you can't use Botski's commands, use '\\*getprefix' or '\\*prefix &'. '*' is anunchangeable backup prefix.", false)
                            .addBlankField(false)
                            .addField("&ping", "A simple command to test that Botski is working", true)
                            .addField("&meow", "A more fun way to test if Botski is working", true)
                            .addField("&whodis", "Gives information about the bot", true)
                            .addField("&commands", "Shows this command list", true)
                            .addField("&prefix", "Changes the bot's prefix (globally) to the first argument", true)
                            .addField("&getprefix", "Gets the bot's current prefix", true)
                            .addField("&prefixinfo", "Shows information about Botski's prefix system", true)
                            .setThumbnail("https://discord.bots.gg/img/bot_icon_placeholder.png")
                            .addBlankField(false)
                            .setFooter("Botski command list by @reddust9");
                    sendEmbed(commands, event);
                    break;
                case "prefix":
                    String newPrefix = args[0];
                    String oldPrefix = prop.getProperty("prefix");
                    prop.setProperty("prefix", newPrefix);
                    send("Prefix has been changed from '" + oldPrefix + "' to '" + newPrefix + "'", event);
                    break;
                case "getprefix":
                    send("The current prefix is '" + prop.getProperty("prefix") + "'", event);
                    break;
                case "prefixinfo":
                    EmbedBuilder prefixinfo = new EmbedBuilder()
                            .setTitle("Botski prefix info")
                            .setColor(new Color(255, 0, 255))
                            .setThumbnail("https://discord.bots.gg/img/bot_icon_placeholder.png")
                            .addField("The prefix info pge for Botski", "Made by @reddust9\nThis page will give you all of the info you need about picking a prefix for your Botski", false)
                            .addBlankField(false)
                            .addField("Point 1.", "DON'T use '*' as a prefix. It will conflict with the hard-coded(ish) backup prefix. And I did not write my code well enough to handle this", true)
                            .addField("Point 2.", "DO use a single-character prefix. Trust me, I have tested this. Botski will only respond to the full prefix, but only remove the first character from the input string. And that could break Botski", true)
                            .addField("Point 3.", "", true)
                            .addBlankField(false)
                            .setFooter("Botski made by @reddust9/ThatOneSammieB");
                    sendEmbed(prefixinfo, event);
                    break;
                case "test":
                    sendDm("Don't worry, " + event.getAuthor().getAsMention() + ". Your test works", event);
                    break;
                case "poll":
                    numUpReactions = 0;
                    numDownReactions = 0;
                    MessageAction thisPoll = event.getChannel().sendMessage("" + args[0]);
                    thisPoll.queue(thisPollMsg -> {
                        thisPollMsg.addReaction("U+2B06").queue();
                        thisPollMsg.addReaction("U+2B07").queue();
                        thisPollMsg.addReaction("U+2705").queue();
                        pollMessgaeId = thisPollMsg.getId();
                    });
                    break;
            }
        }
        super.onMessageReceived(event);
    }
    public void onMessageReactionAdd(@NotNull MessageReactionAddEvent event) {
        if (Objects.requireNonNull(event.getUser()).isBot()) {return;}
        if (!event.getMessageId().equals(pollMessgaeId)) {return;}
        System.out.println("Poll reaction added: " + event.getReactionEmote().getAsReactionCode());
        if (event.getReactionEmote().getAsReactionCode().equals("✅")) {
            numTickReactions++;
            if (numTickReactions < Integer.parseInt(prop.getProperty("minimumPollChecks")))
                return;
            event.getChannel().retrieveMessageById(event.getMessageId()).complete().clearReactions("U+2B06").queue();
            event.getChannel().retrieveMessageById(event.getMessageId()).complete().clearReactions("U+2B07").queue();
            event.getChannel().retrieveMessageById(event.getMessageId()).complete().clearReactions("U+2705").queue();
            String newMessageContent = event.getChannel().retrieveMessageById(event.getMessageId()).complete().getContentDisplay();
            newMessageContent += "\n\n" + prop.getProperty("pollEndedMessage");
            event.getChannel().editMessageById(event.getMessageId(), newMessageContent).queue();
            event.getChannel().retrieveMessageById(event.getMessageId()).complete().getReactions().forEach(thisReaction -> {
                System.out.print(thisReaction.getReactionEmote().getAsReactionCode());
                if (thisReaction.getReactionEmote().getAsReactionCode().equals("⬆")) {
                    numUpReactions++;
                } else if (thisReaction.getReactionEmote().getAsReactionCode().equals("⬇")) {
                    numDownReactions++;
                }
            });
            System.out.println(numTickReactions);
            if (numUpReactions > numDownReactions) {
                sendForReactEvent("Accepted", event);
            } else if (numDownReactions > numUpReactions) {
                sendForReactEvent("Rejected", event);
            } else {
                sendForReactEvent("Tied", event);
            }
        }

    }
    private void send(String msg, @NotNull MessageReceivedEvent event) {event.getChannel().sendMessage(msg).queue();}
    private void sendForReactEvent(String msg, @NotNull MessageReactionAddEvent event) {event.getChannel().sendMessage(msg).queue();}
    private void sendDm(String msg, @NotNull MessageReceivedEvent event) {event.getAuthor().openPrivateChannel().flatMap(channel -> channel.sendMessage(msg)).queue();}
    private void sendEmbed(EmbedBuilder msg, @NotNull MessageReceivedEvent event) {event.getChannel().sendMessage(msg.build()).queue();}
}
