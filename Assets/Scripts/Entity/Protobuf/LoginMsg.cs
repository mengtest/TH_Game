﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temp/LoginMsg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from temp/LoginMsg.proto</summary>
public static partial class LoginMsgReflection {

  #region Descriptor
  /// <summary>File descriptor for temp/LoginMsg.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static LoginMsgReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChN0ZW1wL0xvZ2luTXNnLnByb3RvIi0KCExvZ2luTXNnEhAKCHVzZXJuYW1l",
          "GAEgASgJEg8KB3VzZXJwd2QYAiABKAliBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::LoginMsg), global::LoginMsg.Parser, new[]{ "Username", "Userpwd" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class LoginMsg : pb::IMessage<LoginMsg> {
  private static readonly pb::MessageParser<LoginMsg> _parser = new pb::MessageParser<LoginMsg>(() => new LoginMsg());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<LoginMsg> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoginMsgReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginMsg() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginMsg(LoginMsg other) : this() {
    username_ = other.username_;
    userpwd_ = other.userpwd_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginMsg Clone() {
    return new LoginMsg(this);
  }

  /// <summary>Field number for the "username" field.</summary>
  public const int UsernameFieldNumber = 1;
  private string username_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Username {
    get { return username_; }
    set {
      username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "userpwd" field.</summary>
  public const int UserpwdFieldNumber = 2;
  private string userpwd_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Userpwd {
    get { return userpwd_; }
    set {
      userpwd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as LoginMsg);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(LoginMsg other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Username != other.Username) return false;
    if (Userpwd != other.Userpwd) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Username.Length != 0) hash ^= Username.GetHashCode();
    if (Userpwd.Length != 0) hash ^= Userpwd.GetHashCode();
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
    if (Username.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Username);
    }
    if (Userpwd.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Userpwd);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Username.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
    }
    if (Userpwd.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Userpwd);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(LoginMsg other) {
    if (other == null) {
      return;
    }
    if (other.Username.Length != 0) {
      Username = other.Username;
    }
    if (other.Userpwd.Length != 0) {
      Userpwd = other.Userpwd;
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
        case 10: {
          Username = input.ReadString();
          break;
        }
        case 18: {
          Userpwd = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
