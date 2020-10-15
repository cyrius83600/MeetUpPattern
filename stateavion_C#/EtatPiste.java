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
public class EtatPiste implements Etat{

    public EtatPiste() {
        System.out.println("L'avion est sur la piste");
    }

    @Override
    public Etat sortirDuGarage() {
        System.out.println("L'avion est sur la piste. Impossible de sortir du garage");
        return this;
    }

    @Override
    public Etat entrerAuGarage() {
        System.out.println("L'avion peut entrer au garage");
        return new EtatAuGarage();
    }

    @Override
    public Etat decoller() {
        System.out.println("L'avion peut décoller");
        return new EtatAir();
    }

    @Override
    public Etat atterir() {
        System.out.println("L'avion est sur la piste. Impossible d'atterir");
        return this;
    }
    
}
