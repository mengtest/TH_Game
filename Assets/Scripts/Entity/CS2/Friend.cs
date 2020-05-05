// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Friend.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Friend.proto</summary>
public static partial class FriendReflection {

  #region Descriptor
  /// <summary>File descriptor for Friend.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FriendReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgxGcmllbmQucHJvdG8iQQoGRnJpZW5kEgsKA2ZpZBgBIAEoBRIMCgRuYW1l",
          "GAIgASgJEg4KBm9ubGluZRgDIAEoCBIMCgRpY29uGAQgASgJYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Friend), global::Friend.Parser, new[]{ "Fid", "Name", "Online", "Icon" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Friend : pb::IMessage<Friend> {
  private static readonly pb::MessageParser<Friend> _parser = new pb::MessageParser<Friend>(() => new Friend());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Friend> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FriendReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Friend() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Friend(Friend other) : this() {
    fid_ = other.fid_;
    name_ = other.name_;
    online_ = other.online_;
    icon_ = other.icon_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Friend Clone() {
    return new Friend(this);
  }

  /// <summary>Field number for the "fid" field.</summary>
  public const int FidFieldNumber = 1;
  private int fid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Fid {
    get { return fid_; }
    set {
      fid_ = value;
    }
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 2;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "online" field.</summary>
  public const int OnlineFieldNumber = 3;
  private bool online_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Online {
    get { return online_; }
    set {
      online_ = value;
    }
  }

  /// <summary>Field number for the "icon" field.</summary>
  public const int IconFieldNumber = 4;
  private string icon_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Icon {
    get { return icon_; }
    set {
      icon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Friend);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Friend other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Fid != other.Fid) return false;
    if (Name != other.Name) return false;
    if (Online != other.Online) return false;
    if (Icon != other.Icon) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Fid != 0) hash ^= Fid.GetHashCode();
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (Online != false) hash ^= Online.GetHashCode();
    if (Icon.Length != 0) hash ^= Icon.GetHashCode();
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
    if (Fid != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Fid);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Name);
    }
    if (Online != false) {
      output.WriteRawTag(24);
      output.WriteBool(Online);
    }
    if (Icon.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Icon);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Fid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fid);
    }
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (Online != false) {
      size += 1 + 1;
    }
    if (Icon.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Icon);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Friend other) {
    if (other == null) {
      return;
    }
    if (other.Fid != 0) {
      Fid = other.Fid;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.Online != false) {
      Online = other.Online;
    }
    if (other.Icon.Length != 0) {
      Icon = other.Icon;
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
          Fid = input.ReadInt32();
          break;
        }
        case 18: {
          Name = input.ReadString();
          break;
        }
        case 24: {
          Online = input.ReadBool();
          break;
        }
        case 34: {
          Icon = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
