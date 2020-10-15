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
public class EtatAuGarage implements Etat
{
    public EtatAuGarage() {
        System.out.println("L'avion est au garage");
    }

    @Override
    public Etat sortirDuGarage() {
        System.out.println("L'avion sort du garage");
        return new EtatPiste();
    }

    @Override
    public Etat entrerAuGarage() {
        System.out.println("L'avion est deja au garage. Impossible d'entrer au garage");
        return this;
    }

    @Override
    public Etat decoller() {
        System.out.println("L'avion est au garage. Impossible de decoller");
        return this;
    }

    @Override
    public Etat atterir() {
        System.out.println("L'avion est au garage. Impossible d'atterir");
        return this;
    }

}
