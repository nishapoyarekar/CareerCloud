// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJob.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyJob.proto</summary>
  public static partial class CompanyJobReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyJob.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyJobReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90b3MvQ29tcGFueUpvYi5wcm90bxIQQ2FyZWVyQ2xvdWQuZ1JQQxob",
            "Z29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGh9nb29nbGUvcHJvdG9idWYv",
            "dGltZXN0YW1wLnByb3RvIiEKE0NvbXBhbnlKb2JJZFJlcXVlc3QSCgoCSWQY",
            "ASABKAkikQEKEUNvbXBhbnlKb2JQYXlsb2FkEgoKAklkGAEgASgJEg8KB0Nv",
            "bXBhbnkYAiABKAkSMgoOUHJvZmlsZUNyZWF0ZWQYAyABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuVGltZXN0YW1wEhIKCklzSW5hY3RpdmUYBCABKAgSFwoPSXND",
            "b21wYW55SGlkZGVuGAUgASgIMt0CCgpDb21wYW55Sm9iElwKDlJlYWRDb21w",
            "YW55Sm9iEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iSWRSZXF1ZXN0",
            "GiMuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iUGF5bG9hZBJPChBDcmVh",
            "dGVDb21wYW55Sm9iEiMuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iUGF5",
            "bG9hZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJPChBVcGRhdGVDb21wYW55",
            "Sm9iEiMuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iUGF5bG9hZBoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eRJPChBEZWxldGVDb21wYW55Sm9iEiMuQ2Fy",
            "ZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iUGF5bG9hZBoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eUIaqgIXQ2FyZWVyQ2xvdWQuZ1JQQy5Qcm90b3NiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobIdRequest), global::CareerCloud.gRPC.Protos.CompanyJobIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobPayload), global::CareerCloud.gRPC.Protos.CompanyJobPayload.Parser, new[]{ "Id", "Company", "ProfileCreated", "IsInactive", "IsCompanyHidden" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompanyJobIdRequest : pb::IMessage<CompanyJobIdRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CompanyJobIdRequest> _parser = new pb::MessageParser<CompanyJobIdRequest>(() => new CompanyJobIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CompanyJobIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompanyJobIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompanyJobIdRequest(CompanyJobIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompanyJobIdRequest Clone() {
      return new CompanyJobIdRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CompanyJobIdRequest other) {
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CompanyJobIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
            Id = input.ReadString();
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
            Id = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CompanyJobPayload : pb::IMessage<CompanyJobPayload>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CompanyJobPayload> _parser = new pb::MessageParser<CompanyJobPayload>(() => new CompanyJobPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CompanyJobPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompanyJobPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompanyJobPayload(CompanyJobPayload other) : this() {
      id_ = other.id_;
      company_ = other.company_;
      profileCreated_ = other.profileCreated_ != null ? other.profileCreated_.Clone() : null;
      isInactive_ = other.isInactive_;
      isCompanyHidden_ = other.isCompanyHidden_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompanyJobPayload Clone() {
      return new CompanyJobPayload(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Company" field.</summary>
    public const int CompanyFieldNumber = 2;
    private string company_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProfileCreated" field.</summary>
    public const int ProfileCreatedFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp profileCreated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ProfileCreated {
      get { return profileCreated_; }
      set {
        profileCreated_ = value;
      }
    }

    /// <summary>Field number for the "IsInactive" field.</summary>
    public const int IsInactiveFieldNumber = 4;
    private bool isInactive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInactive {
      get { return isInactive_; }
      set {
        isInactive_ = value;
      }
    }

    /// <summary>Field number for the "IsCompanyHidden" field.</summary>
    public const int IsCompanyHiddenFieldNumber = 5;
    private bool isCompanyHidden_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCompanyHidden {
      get { return isCompanyHidden_; }
      set {
        isCompanyHidden_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CompanyJobPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Company != other.Company) return false;
      if (!object.Equals(ProfileCreated, other.ProfileCreated)) return false;
      if (IsInactive != other.IsInactive) return false;
      if (IsCompanyHidden != other.IsCompanyHidden) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (profileCreated_ != null) hash ^= ProfileCreated.GetHashCode();
      if (IsInactive != false) hash ^= IsInactive.GetHashCode();
      if (IsCompanyHidden != false) hash ^= IsCompanyHidden.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      if (profileCreated_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfileCreated);
      }
      if (IsInactive != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsInactive);
      }
      if (IsCompanyHidden != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCompanyHidden);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      if (profileCreated_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfileCreated);
      }
      if (IsInactive != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsInactive);
      }
      if (IsCompanyHidden != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCompanyHidden);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (profileCreated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfileCreated);
      }
      if (IsInactive != false) {
        size += 1 + 1;
      }
      if (IsCompanyHidden != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CompanyJobPayload other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.profileCreated_ != null) {
        if (profileCreated_ == null) {
          ProfileCreated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ProfileCreated.MergeFrom(other.ProfileCreated);
      }
      if (other.IsInactive != false) {
        IsInactive = other.IsInactive;
      }
      if (other.IsCompanyHidden != false) {
        IsCompanyHidden = other.IsCompanyHidden;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Company = input.ReadString();
            break;
          }
          case 26: {
            if (profileCreated_ == null) {
              ProfileCreated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProfileCreated);
            break;
          }
          case 32: {
            IsInactive = input.ReadBool();
            break;
          }
          case 40: {
            IsCompanyHidden = input.ReadBool();
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Company = input.ReadString();
            break;
          }
          case 26: {
            if (profileCreated_ == null) {
              ProfileCreated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProfileCreated);
            break;
          }
          case 32: {
            IsInactive = input.ReadBool();
            break;
          }
          case 40: {
            IsCompanyHidden = input.ReadBool();
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
