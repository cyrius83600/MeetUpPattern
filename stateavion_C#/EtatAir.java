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
public class EtatAir implements Etat{

    public EtatAir() {
        System.out.println("L'avion vole");
    }

    @Override
    public Etat sortirDuGarage() {
        System.out.println("L'avion est en l'air. Impossible de sortir du garage");
        return this;
    }

    @Override
    public Etat entrerAuGarage() {
        System.out.println("L'avion est en l'air. Impossible d'entrer au garage");
        return this;
    }

    @Override
    public Etat decoller() {
        System.out.println("L'avion est en l'air. Impossible de décoller");
        return this;
    }

    @Override
    public Etat atterir() {
        System.out.println("L'avion peut atterir");
        return new EtatPiste();
    }
    
}
