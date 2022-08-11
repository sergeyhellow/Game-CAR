using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Race_track
    {
        int dist { get; set; }
        string Surf;
        protected Dictionary<int, string> dist_surface = new Dictionary<int, string>
        {
               { 1, "asphalt"},
               { 2, "ground"},
               { 3, "snow"}
        };

       public Race_track() { }



        public string get_Surf(int num) 
        {
            
            return this.Surf = dist_surface[num];
        }










    }
}
