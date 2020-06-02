using System;

namespace ExempleJedis
{
    public class Jedi
    {
        public int PointsDevie { get; set; }
        public void Attaquer(Droide droide)
        {
            if(droide != null)
            {
                droide.PointsDevie -= 50;
            }

            //throw new NotImplementedException();
        }
    }
}
