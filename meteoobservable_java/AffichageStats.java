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
public class AffichageStats implements Observateur, Affichage {

    public float temperature;
    public float hygrometrie;
    public float pression;
    public Sujet donneesMeteo;
    
    public AffichageStats() {}
    
    public AffichageStats(Sujet donneesMeteo) 
    {
        this.donneesMeteo = donneesMeteo;
        donneesMeteo.enregistrerObservateur(this);
    }
    
    @Override
    public void actualiser(float temperature, float hygrometrie, float pression) {
        this.temperature = temperature;
        this.hygrometrie = hygrometrie;
        this.pression = pression;
        afficher();
    }
    
    @Override
    public void afficher()
    {
        System.out.println("Temp. Moy/Maxi/Mini : " + temperature + "/" + (temperature + 1) + "/" + (temperature - 1));
    }
    
}
