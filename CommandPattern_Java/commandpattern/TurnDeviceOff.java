/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package commandpattern;

/**
 *
 * @author Utilisateur
 */
public class TurnDeviceOff implements Command{
    ElectronicDevice theDevice;

    public TurnDeviceOff(ElectronicDevice theDevice) {
        this.theDevice = theDevice;
    }
    
    @Override
    public void execute() {
        theDevice.off();
    }
}
