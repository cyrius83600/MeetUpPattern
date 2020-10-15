/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MeteoObservable;
import java.util.Observable;
import java.util.Observer;

/**
 *
 * @author CONCAS Cyril
 */
public class AffichageConditions implements Observer, Affichage{

    public float temperature;
    public float hygrometrie;
    public float pression;
    //public Sujet donneesMeteo;
    public Observable observable;
    
    public AffichageConditions() {}
    

    
    public AffichageConditions(Observable observable) 
    {
        this.observable = observable;
        observable.addObserver(this);
    }
    
    @Override
    public void afficher() {
        String s1 = "Temperateure : " + temperature + "C ";
        String s2 = "Humidite : " + hygrometrie + "% ";
        String s3 = "Pression : " + pression + "Pa ";
        System.out.println(s1 + s2 + s3);
    }

    @Override
    public void update(Observable obs, Object arg1) {
        if(obs instanceof DonneesMeteo)
        {
            DonneesMeteo donneesMeteo = (DonneesMeteo)obs;
            this.temperature = donneesMeteo.temperature;
            this.hygrometrie = donneesMeteo.hygrometrie;
            this.pression = donneesMeteo.pression;
            afficher();
        }
    }
    
    
    
    
}
