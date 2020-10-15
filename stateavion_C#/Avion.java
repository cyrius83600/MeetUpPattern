/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package stateavion;

/**
 *
 * @author Utilisateur
 */
public class Avion {
    
    private Etat etat;
    
    public Avion()
    {
        etat = new EtatAuGarage();
    }

    public void sortirDuGarage() {
        etat = etat.sortirDuGarage();
    }

    public void entrerAuGarage() {
        etat = etat.entrerAuGarage();
    }

    public void decoller() {
        etat = etat.decoller();
    }

    public void atterir() {
        etat = etat.atterir();
    }
    

    
    
   
    
}
