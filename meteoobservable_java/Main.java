/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MeteoObservable;

/**
 *
 * @author CONCAS Cyril
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        DonneesMeteo donnees = new DonneesMeteo();
        AffichageConditions affichageCond = new AffichageConditions(donnees);
        donnees.SetMesures(100, 20, 50);
    }
}
