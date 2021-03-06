// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Cards.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Cards.proto</summary>
public static partial class CardsReflection {

  #region Descriptor
  /// <summary>File descriptor for Cards.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CardsReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgtDYXJkcy5wcm90byIzCgVDYXJkcxIWCgFjGAIgAygLMgsuQ2FyZHMuQ2Fy",
          "ZBoSCgRDYXJkEgoKAmlkGAEgASgFYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Cards), global::Cards.Parser, new[]{ "C" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Cards.Types.Card), global::Cards.Types.Card.Parser, new[]{ "Id" }, null, null, null)})
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Cards : pb::IMessage<Cards> {
  private static readonly pb::MessageParser<Cards> _parser = new pb::MessageParser<Cards>(() => new Cards());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Cards> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CardsReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Cards() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Cards(Cards other) : this() {
    c_ = other.c_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Cards Clone() {
    return new Cards(this);
  }

  /// <summary>Field number for the "c" field.</summary>
  public const int CFieldNumber = 2;
  private static readonly pb::FieldCodec<global::Cards.Types.Card> _repeated_c_codec
      = pb::FieldCodec.ForMessage(18, global::Cards.Types.Card.Parser);
  private readonly pbc::RepeatedField<global::Cards.Types.Card> c_ = new pbc::RepeatedField<global::Cards.Types.Card>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Cards.Types.Card> C {
    get { return c_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Cards);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Cards other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!c_.Equals(other.c_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= c_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    c_.WriteTo(output, _repeated_c_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += c_.CalculateSize(_repeated_c_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Cards other) {
    if (other == null) {
      return;
    }
    c_.Add(other.c_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 18: {
          c_.AddEntriesFrom(input, _repeated_c_codec);
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the Cards message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public sealed partial class Card : pb::IMessage<Card> {
      private static readonly pb::MessageParser<Card> _parser = new pb::MessageParser<Card>(() => new Card());
      private pb::UnknownFieldSet _unknownFields;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public static pb::MessageParser<Card> Parser { get { return _parser; } }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public static pbr::MessageDescriptor Descriptor {
        get { return global::Cards.Descriptor.NestedTypes[0]; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Card() {
        OnConstruction();
      }

      partial void OnConstruction();

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Card(Card other) : this() {
        id_ = other.id_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public Card Clone() {
        return new Card(this);
      }

      /// <summary>Field number for the "id" field.</summary>
      public const int IdFieldNumber = 1;
      private int id_;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public int Id {
        get { return id_; }
        set {
          id_ = value;
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public override bool Equals(object other) {
        return Equals(other as Card);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public bool Equals(Card other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if (Id != other.Id) return false;
        return Equals(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public override int GetHashCode() {
        int hash = 1;
        if (Id != 0) hash ^= Id.GetHashCode();
        if (_unknownFields != null) {
          hash ^= _unknownFields.GetHashCode();
        }
        return hash;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public override string ToString() {
        return pb::JsonFormatter.ToDiagnosticString(this);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public void WriteTo(pb::CodedOutputStream output) {
        if (Id != 0) {
          output.WriteRawTag(8);
          output.WriteInt32(Id);
        }
        if (_unknownFields != null) {
          _unknownFields.WriteTo(output);
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public int CalculateSize() {
        int size = 0;
        if (Id != 0) {
          size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
        }
        if (_unknownFields != null) {
          size += _unknownFields.CalculateSize();
        }
        return size;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public void MergeFrom(Card other) {
        if (other == null) {
          return;
        }
        if (other.Id != 0) {
          Id = other.Id;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      public void MergeFrom(pb::CodedInputStream input) {
        uint tag;
        while ((tag = input.ReadTag()) != 0) {
          switch(tag) {
            default:
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
              break;
            case 8: {
              Id = input.ReadInt32();
              break;
            }
          }
        }
      }

    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
