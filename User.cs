// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: User.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Kafka {

  /// <summary>Holder for reflection information generated from User.proto</summary>
  public static partial class UserReflection {

    #region Descriptor
    /// <summary>File descriptor for User.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpVc2VyLnByb3RvIj8KBFVzZXISDgoGdXNlcmlkGAEgASgDEgwKBG5hbWUY",
            "AiABKAkSGQoHY29udGFjdBgDIAEoCzIILkNvbnRhY3QiNAoHQ29udGFjdBIN",
            "CgVwaG9uZRgBIAEoAxINCgVlbWFpbBgCIAEoCRILCgNmYXgYAyABKAlCCKoC",
            "BUthZmthYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Kafka.User), global::Kafka.User.Parser, new[]{ "Userid", "Name", "Contact" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Kafka.Contact), global::Kafka.Contact.Parser, new[]{ "Phone", "Email", "Fax" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class User : pb::IMessage<User>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Kafka.UserReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      userid_ = other.userid_;
      name_ = other.name_;
      contact_ = other.contact_ != null ? other.contact_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "userid" field.</summary>
    public const int UseridFieldNumber = 1;
    private long userid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Userid {
      get { return userid_; }
      set {
        userid_ = value;
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

    /// <summary>Field number for the "contact" field.</summary>
    public const int ContactFieldNumber = 3;
    private global::Kafka.Contact contact_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Kafka.Contact Contact {
      get { return contact_; }
      set {
        contact_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Userid != other.Userid) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(Contact, other.Contact)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Userid != 0L) hash ^= Userid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (contact_ != null) hash ^= Contact.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Userid != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Userid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (contact_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Contact);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Userid != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Userid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (contact_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Contact);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Userid != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Userid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (contact_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Contact);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.Userid != 0L) {
        Userid = other.Userid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.contact_ != null) {
        if (contact_ == null) {
          Contact = new global::Kafka.Contact();
        }
        Contact.MergeFrom(other.Contact);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Userid = input.ReadInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            if (contact_ == null) {
              Contact = new global::Kafka.Contact();
            }
            input.ReadMessage(Contact);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Userid = input.ReadInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            if (contact_ == null) {
              Contact = new global::Kafka.Contact();
            }
            input.ReadMessage(Contact);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Contact : pb::IMessage<Contact>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Contact> _parser = new pb::MessageParser<Contact>(() => new Contact());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Contact> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Kafka.UserReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Contact() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Contact(Contact other) : this() {
      phone_ = other.phone_;
      email_ = other.email_;
      fax_ = other.fax_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Contact Clone() {
      return new Contact(this);
    }

    /// <summary>Field number for the "phone" field.</summary>
    public const int PhoneFieldNumber = 1;
    private long phone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Phone {
      get { return phone_; }
      set {
        phone_ = value;
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 2;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fax" field.</summary>
    public const int FaxFieldNumber = 3;
    private string fax_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Fax {
      get { return fax_; }
      set {
        fax_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Contact);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Contact other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Phone != other.Phone) return false;
      if (Email != other.Email) return false;
      if (Fax != other.Fax) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Phone != 0L) hash ^= Phone.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Fax.Length != 0) hash ^= Fax.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Phone != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Phone);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (Fax.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Fax);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Phone != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Phone);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (Fax.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Fax);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Phone != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Phone);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Fax.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Fax);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Contact other) {
      if (other == null) {
        return;
      }
      if (other.Phone != 0L) {
        Phone = other.Phone;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Fax.Length != 0) {
        Fax = other.Fax;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Phone = input.ReadInt64();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 26: {
            Fax = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Phone = input.ReadInt64();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 26: {
            Fax = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
