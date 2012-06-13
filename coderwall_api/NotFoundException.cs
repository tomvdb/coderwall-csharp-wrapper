using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coderwall_api
{
  public class NotFoundException : System.Exception
  {
    public NotFoundException( string message ) : base( message )
    {
    }
  }
}
