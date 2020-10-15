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
public interface Sujet {
    public void enregistrerObservateur(Observateur o);
    public void supprimerObservateur(Observateur o);
    public void notifierObservateurs();
}
