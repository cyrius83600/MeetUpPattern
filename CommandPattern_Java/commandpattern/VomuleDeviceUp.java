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
public class VomuleDeviceUp implements Command{
    ElectronicDevice theDevice;

    public VomuleDeviceUp(ElectronicDevice theDevice) {
        this.theDevice = theDevice;
    }
    
    @Override
    public void execute() {
        theDevice.volumeUp();
    }
}
