package uk.co.samuelbennett.botski;

import java.io.*;
import java.util.Properties;

public class PropReader {
    public static Properties readProps() {
        try (InputStream input = Main.class.getClassLoader().getResourceAsStream("config.properties")) {

            Properties prop = new Properties();

            if (input == null) {
                System.out.println("Sorry, unable to find config.properties");
                return null;
            }

            // load a properties file
            prop.load(input);
            return prop;

        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return null;
    }
    public static void initProps() {
        try (OutputStream output = new FileOutputStream("src/main/resources/config.properties")) {

            Properties prop = new Properties();

            // set the properties value
            prop.setProperty("token", "your_token_here");
            prop.setProperty("prefix", "&");

            // save properties to project root folder
            prop.store(output, null);

            System.out.println(prop);

        } catch (IOException io) {
            io.printStackTrace();
        }
    }
    public static void saveProps(Properties prop) {
        try (OutputStream output = new FileOutputStream("src/main/resources/config.properties")) {

            // save properties to project root folder
            prop.store(output, null);

        } catch (IOException io) {
            io.printStackTrace();
        }
    }
}
