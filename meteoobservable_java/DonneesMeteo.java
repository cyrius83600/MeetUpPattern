/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MeteoObservable;

import java.util.ArrayList;
import java.util.Observable;
import java.util.Observer;

/**
 *
 * @author CONCAS Cyril
 */

//public class DonneesMeteo implements  Sujet{
public class DonneesMeteo extends Observable{
    
    public float temperature;
    public float hygrometrie;
    public float pression;

    public DonneesMeteo() 
    {
        //observateurs = new ArrayList();
    }
    

    


    
    public void ActualiserMesures()
    {
        //notifierObservateurs();
        setChanged();
        notifyObservers();
    }
    
    public void SetMesures(float temperature, float hygrometrie, float pression)
    {
        this.temperature = temperature;
        this.hygrometrie = hygrometrie;
        this.pression = pression;
        ActualiserMesures();
    }
}
