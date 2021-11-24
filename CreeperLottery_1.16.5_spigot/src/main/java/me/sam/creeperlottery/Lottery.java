package me.sam.creeperlottery;

import org.bukkit.Location;
import org.bukkit.World;
import org.bukkit.command.CommandExecutor;
import org.bukkit.command.CommandSender;
import org.bukkit.entity.EntityType;
import org.bukkit.entity.Player;
import org.bukkit.command.Command;
import org.bukkit.event.Listener;

public class Lottery implements CommandExecutor, Listener {

    public Lottery() {

    }




        public boolean onCommand (CommandSender sender, Command cmd, String label, String[]args){
            Player p = (Player) sender;
            Location loc = p.getLocation();
            World w = p.getWorld();
            int rand = (int) Math.floor(Math.random() * 20);
            System.out.printf("Count: %s%n", rand);
            String arg1 = args[0];
            if (arg1.equals("creeper")){
                for (int i = 0; i < rand; i++) w.spawnEntity(loc, EntityType.CREEPER);
            }
            if (arg1.equals("zombie")){
                for (int i = 0; i < rand; i++) w.spawnEntity(loc, EntityType.ZOMBIE);
            }
            if ((arg1.equals("skeleton"))) {
                for (int i = 0; i < rand; i++) w.spawnEntity(loc, EntityType.SKELETON);
            }
            if ((arg1.equals("spider"))) {
                for (int i = 0; i < rand; i++) w.spawnEntity(loc, EntityType.SPIDER);
            }

            if ((arg1.equals("BOSS"))) {
                System.out.printf("Boss: %s%n", rand);
                if (rand < 14){
                    w.spawnEntity(loc, EntityType.ENDER_DRAGON);
                }
                else if (rand > 14 && rand < 17){
                    w.spawnEntity(loc, EntityType.WITHER);
                }
                else if (rand > 17){
                    w.spawnEntity(loc, EntityType.ELDER_GUARDIAN);
                }
                else if (rand > 14 && Math.floor(Math.random()) * 10 < 7){
                    for (int i = 0; i < 69; i++) w.spawnEntity(loc, EntityType.DROWNED);
                }
            }
            return true;
        }



}
