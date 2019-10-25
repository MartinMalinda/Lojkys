using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningTalk
{
    class Forward : Player
   {    public override void Jump()
        {
      for (int i = 0; i < 10; i++)
      {
  Console.WriteLine("test");
        }
    }

public override void Move()
      {
 throw new NotImplementedException();
  }

    public override void Shoot()
   {
         throw new NotImplementedException();
     }
    }
}
