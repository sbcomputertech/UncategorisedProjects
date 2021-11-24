package me.sam.creeperlottery;

import org.bukkit.plugin.java.JavaPlugin;

public final class Main extends JavaPlugin {

    @Override
    public void onEnable() {
        // Plugin startup logic
        System.out.println("Hello world");
        getServer().getPluginManager().registerEvents(new Lottery(), this);
        this.getCommand("creeperlottery").setExecutor(new Lottery());

    }

    @Override
    public void onDisable() {
        // Plugin shutdown logic
    }
}
