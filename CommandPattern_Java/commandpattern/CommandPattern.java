/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package commandpattern;

import java.util.ArrayList;
import java.util.List;



/**
 *
 * @author Utilisateur
 */
public class CommandPattern {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ElectronicDevice newDevice = TVRemote.getDevice();
        
        TurnDeviceOn onCommand = new TurnDeviceOn(newDevice);
        DeviceButton onPressed = new DeviceButton(onCommand);
        onPressed.press();
    }
    
}
