// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Bbb.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Bbb.proto</summary>
public static partial class BbbReflection {

  #region Descriptor
  /// <summary>File descriptor for Bbb.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BbbReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CglCYmIucHJvdG8i0QEKDVNpbXBsZU1lc3NhZ2USCgoCaWQYASABKAQSKQoM",
          "bWVzc2FnZV90eXBlGAIgASgOMhMuU2ltcGxlTWVzc2FnZS5UeXBlEioKB2hl",
          "YWRlcnMYAyADKAsyGS5TaW1wbGVNZXNzYWdlLkhlYWRlckl0ZW0SDAoEYmxv",
          "YhgEIAEoDBopCgpIZWFkZXJJdGVtEgwKBG5hbWUYASABKAkSDQoFdmFsdWUY",
          "AiABKAkiJAoEVHlwZRIJCgVTVEFSVBAAEggKBEJMT0IQARIHCgNFTkQQAkIh",
          "Wh9leGFtcGxlLmNvbS9wcm9qZWN0L3Byb3Rvcy9maXp6YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SimpleMessage), global::SimpleMessage.Parser, new[]{ "Id", "MessageType", "Headers", "Blob" }, null, new[]{ typeof(global::SimpleMessage.Types.Type) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::SimpleMessage.Types.HeaderItem), global::SimpleMessage.Types.HeaderItem.Parser, new[]{ "Name", "Value" }, null, null, null, null)})
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SimpleMessage : pb::IMessage<SimpleMessage>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SimpleMessage> _parser = new pb::MessageParser<SimpleMessage>(() => new SimpleMessage());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SimpleMessage> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BbbReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SimpleMessage() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SimpleMessage(SimpleMessage other) : this() {
    id_ = other.id_;
    messageType_ = other.messageType_;
    headers_ = other.headers_.Clone();
    blob_ = other.blob_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SimpleMessage Clone() {
    return new SimpleMessage(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private ulong id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "message_type" field.</summary>
  public const int MessageTypeFieldNumber = 2;
  private global::SimpleMessage.Types.Type messageType_ = global::SimpleMessage.Types.Type.Start;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::SimpleMessage.Types.Type MessageType {
    get { return messageType_; }
    set {
      messageType_ = value;
    }
  }

  /// <summary>Field number for the "headers" field.</summary>
  public const int HeadersFieldNumber = 3;
  private static readonly pb::FieldCodec<global::SimpleMessage.Types.HeaderItem> _repeated_headers_codec
      = pb::FieldCodec.ForMessage(26, global::SimpleMessage.Types.HeaderItem.Parser);
  private readonly pbc::RepeatedField<global::SimpleMessage.Types.HeaderItem> headers_ = new pbc::RepeatedField<global::SimpleMessage.Types.HeaderItem>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::SimpleMessage.Types.HeaderItem> Headers {
    get { return headers_; }
  }

  /// <summary>Field number for the "blob" field.</summary>
  public const int BlobFieldNumber = 4;
  private pb::ByteString blob_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pb::ByteString Blob {
    get { return blob_; }
    set {
      blob_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SimpleMessage);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SimpleMessage other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (MessageType != other.MessageType) return false;
    if(!headers_.Equals(other.headers_)) return false;
    if (Blob != other.Blob) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0UL) hash ^= Id.GetHashCode();
    if (MessageType != global::SimpleMessage.Types.Type.Start) hash ^= MessageType.GetHashCode();
    hash ^= headers_.GetHashCode();
    if (Blob.Length != 0) hash ^= Blob.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Id != 0UL) {
      output.WriteRawTag(8);
      output.WriteUInt64(Id);
    }
    if (MessageType != global::SimpleMessage.Types.Type.Start) {
      output.WriteRawTag(16);
      output.WriteEnum((int) MessageType);
    }
    headers_.WriteTo(output, _repeated_headers_codec);
    if (Blob.Length != 0) {
      output.WriteRawTag(34);
      output.WriteBytes(Blob);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Id != 0UL) {
      output.WriteRawTag(8);
      output.WriteUInt64(Id);
    }
    if (MessageType != global::SimpleMessage.Types.Type.Start) {
      output.WriteRawTag(16);
      output.WriteEnum((int) MessageType);
    }
    headers_.WriteTo(ref output, _repeated_headers_codec);
    if (Blob.Length != 0) {
      output.WriteRawTag(34);
      output.WriteBytes(Blob);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Id);
    }
    if (MessageType != global::SimpleMessage.Types.Type.Start) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
    }
    size += headers_.CalculateSize(_repeated_headers_codec);
    if (Blob.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Blob);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SimpleMessage other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0UL) {
      Id = other.Id;
    }
    if (other.MessageType != global::SimpleMessage.Types.Type.Start) {
      MessageType = other.MessageType;
    }
    headers_.Add(other.headers_);
    if (other.Blob.Length != 0) {
      Blob = other.Blob;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          Id = input.ReadUInt64();
          break;
        }
        case 16: {
          MessageType = (global::SimpleMessage.Types.Type) input.ReadEnum();
          break;
        }
        case 26: {
          headers_.AddEntriesFrom(input, _repeated_headers_codec);
          break;
        }
        case 34: {
          Blob = input.ReadBytes();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Id = input.ReadUInt64();
          break;
        }
        case 16: {
          MessageType = (global::SimpleMessage.Types.Type) input.ReadEnum();
          break;
        }
        case 26: {
          headers_.AddEntriesFrom(ref input, _repeated_headers_codec);
          break;
        }
        case 34: {
          Blob = input.ReadBytes();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the SimpleMessage message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum Type {
      [pbr::OriginalName("START")] Start = 0,
      [pbr::OriginalName("BLOB")] Blob = 1,
      [pbr::OriginalName("END")] End = 2,
    }

    public sealed partial class HeaderItem : pb::IMessage<HeaderItem>
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , pb::IBufferMessage
    #endif
    {
      private static readonly pb::MessageParser<HeaderItem> _parser = new pb::MessageParser<HeaderItem>(() => new HeaderItem());
      private pb::UnknownFieldSet _unknownFields;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pb::MessageParser<HeaderItem> Parser { get { return _parser; } }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pbr::MessageDescriptor Descriptor {
        get { return global::SimpleMessage.Descriptor.NestedTypes[0]; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public HeaderItem() {
        OnConstruction();
      }

      partial void OnConstruction();

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public HeaderItem(HeaderItem other) : this() {
        name_ = other.name_;
        value_ = other.value_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public HeaderItem Clone() {
        return new HeaderItem(this);
      }

      /// <summary>Field number for the "name" field.</summary>
      public const int NameFieldNumber = 1;
      private string name_ = "";
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public string Name {
        get { return name_; }
        set {
          name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        }
      }

      /// <summary>Field number for the "value" field.</summary>
      public const int ValueFieldNumber = 2;
      private string value_ = "";
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public string Value {
        get { return value_; }
        set {
          value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override bool Equals(object other) {
        return Equals(other as HeaderItem);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public bool Equals(HeaderItem other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if (Name != other.Name) return false;
        if (Value != other.Value) return false;
        return Equals(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override int GetHashCode() {
        int hash = 1;
        if (Name.Length != 0) hash ^= Name.GetHashCode();
        if (Value.Length != 0) hash ^= Value.GetHashCode();
        if (_unknownFields != null) {
          hash ^= _unknownFields.GetHashCode();
        }
        return hash;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override string ToString() {
        return pb::JsonFormatter.ToDiagnosticString(this);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public void WriteTo(pb::CodedOutputStream output) {
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
      #else
        if (Name.Length != 0) {
          output.WriteRawTag(10);
          output.WriteString(Name);
        }
        if (Value.Length != 0) {
          output.WriteRawTag(18);
          output.WriteString(Value);
        }
        if (_unknownFields != null) {
          _unknownFields.WriteTo(output);
        }
      #endif
      }

      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
        if (Name.Length != 0) {
          output.WriteRawTag(10);
          output.WriteString(Name);
        }
        if (Value.Length != 0) {
          output.WriteRawTag(18);
          output.WriteString(Value);
        }
        if (_unknownFields != null) {
          _unknownFields.WriteTo(ref output);
        }
      }
      #endif

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public int CalculateSize() {
        int size = 0;
        if (Name.Length != 0) {
          size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
        }
        if (Value.Length != 0) {
          size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
        }
        if (_unknownFields != null) {
          size += _unknownFields.CalculateSize();
        }
        return size;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public void MergeFrom(HeaderItem other) {
        if (other == null) {
          return;
        }
        if (other.Name.Length != 0) {
          Name = other.Name;
        }
        if (other.Value.Length != 0) {
          Value = other.Value;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            case 10: {
              Name = input.ReadString();
              break;
            }
            case 18: {
              Value = input.ReadString();
              break;
            }
          }
        }
      #endif
      }

      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
        uint tag;
        while ((tag = input.ReadTag()) != 0) {
          switch(tag) {
            default:
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
              break;
            case 10: {
              Name = input.ReadString();
              break;
            }
            case 18: {
              Value = input.ReadString();
              break;
            }
          }
        }
      }
      #endif

    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
