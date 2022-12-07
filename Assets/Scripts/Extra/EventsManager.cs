using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class EventsManager : MonoBehaviour
    {
        //this will contain ALL OF OUR EVENTS
        
        //events delefates have TWO PARTS
        //the DELEGATE whichis the "type of event"
        //the EVENT itself, which gets "announced"

        //This is the TYPE of event you would call
        public delegate void VoidDelegate();
        //This is the EVENT itself
        public static VoidDelegate OnTeleportEvent;
        public static VoidDelegate OnChangeColourEvent;
    }

}
