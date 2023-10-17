namespace Catalog
{
  using System . Numerics;

  internal class Program
  {
    static void Main ( string [ ] args )
    {
      Console . WriteLine ( "Hello, World!" );

      Catalog<string, BigInteger> catalog = new Catalog<string, BigInteger> ( );
      catalog . Increment ( );

      Set<BigInteger> set = new Set<BigInteger> ( );
      set . Add ( BigInteger . One );
      set . Add ( BigInteger . Zero );
      set . Add ( BigInteger . One );

      //set . Revolve ( );

      foreach ( BigInteger item in set )
      {
        Console . WriteLine ( item );
      }

      Console . WriteLine ( set [1] );

      Console . ReadLine ( );
    }
  }
}
