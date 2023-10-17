using System;
using System . Collections;
using System . Collections . Generic;
using System . Linq;
using System . Numerics;
using System . Reflection;
using System . Text;
using System . Threading . Tasks;

public class Set<T>
{
  private class Entity
  {
    private Entity? Tail { get; set; } = null;
    private T Member { get; set; } = default ( T )!;

    public Entity ( T Data )
    {
      this . Members = Data;
    }

    public Entity Element
    {
      get { return this.Tail!; }
      set { this . Tail = value; }
    }

    public T Members
    {
      get { return this.Member!; }
      set { this . Member = value; }
    }
  }

  public static readonly string [ ] Name = new string [ ] { "Generic Set", "Set" };
  private BigInteger Count = BigInteger.Zero;
  private Entity? Head { get; set; } = null;

  private static Set<T>? Initiable { get; set; } = null;

  public static Set<T> Initial
  {
    get
    {
      if ( Initiable is null )
      {
        Initiable = new Set<T> ( );
      }
      return Initiable;
    }
  }

  private Entity Get(BigInteger Index)
  {
    Entity? Entity = this.Head;
    for ( BigInteger i = 0 ; i < Index && Entity is not null ; i++ )
    {
      Entity = Entity . Element;
    }
    if ( Entity is not null )
    {
      return Entity;
    }
    throw new IndexOutOfRangeException ( );
  }

  public T this [ BigInteger index ]
  {
    get
    {
      return this . Get ( index ) . Members;
    }
    set
    {
      this . Get ( index ) .Members = value;
    }
  }

  public Set ( )
  {
  }

  public IEnumerator<T> GetEnumerator ( )
  {
    Entity? current = this.Head;
    while ( current != null )
    {
      yield return current . Members;
      current = current . Element;
    }
  }

  public bool Add ( T member )
  {
    try
    {
      Entity element = new Entity(member);
      element . Element = this . Head!;
      this . Head = element;
      return true;
    } catch { }
    return false;
  }

  public void Clear ( )
  {
    this . Head = null;
  }

  public bool Contains ( T item )
  {
    foreach ( T member in this )
    {
      if ( member is not null && member . Equals ( item ) )
      {
        return true;
      }
    }
    return false;
  }

  public bool SetEquals<T> ( Set<T> b )
  {
    return true;
  }
}