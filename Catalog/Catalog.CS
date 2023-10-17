using System . Collections . Generic;
using System . Linq;
using System . Numerics;
using System . Security . Cryptography;

public class Catalog<TKey, TTag> where TKey : notnull where TTag : IBinaryInteger<TTag>
{
  private TTag Id = TTag.Zero;
  private Dictionary<Set<TKey>, Set<TTag>> IdsKey = new Dictionary<Set<TKey>, Set<TTag>>(new SetComparer<TKey>());
  private Dictionary<Set<TTag>, Set<TTag>> KeyTag = new Dictionary<Set<TTag>, Set<TTag>>(new SetComparer<TTag>());

  public Catalog ( )
  {
  }

  public void Increment ( )
  {
    this . Id = this . Id + TTag . One;
  }
}