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
public interface Etat
{
    // Transitions d'etat 
    public Etat sortirDuGarage();
    public Etat entrerAuGarage();
    public Etat decoller();
    public Etat atterir();
}
