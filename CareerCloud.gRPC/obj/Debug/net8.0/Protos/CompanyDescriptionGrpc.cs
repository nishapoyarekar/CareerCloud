// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyDescription.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class CompanyDescription
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.CompanyDescription";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest> __Marshaller_CareerCloud_gRPC_CompanyDescriptionIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload> __Marshaller_CareerCloud_gRPC_CompanyDescriptionPayload = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest, global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload> __Method_ReadCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest, global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadCompanyDescription",
        __Marshaller_CareerCloud_gRPC_CompanyDescriptionIdRequest,
        __Marshaller_CareerCloud_gRPC_CompanyDescriptionPayload);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCompanyDescription",
        __Marshaller_CareerCloud_gRPC_CompanyDescriptionPayload,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCompanyDescription",
        __Marshaller_CareerCloud_gRPC_CompanyDescriptionPayload,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCompanyDescription = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCompanyDescription",
        __Marshaller_CareerCloud_gRPC_CompanyDescriptionPayload,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CompanyDescription</summary>
    [grpc::BindServiceMethod(typeof(CompanyDescription), "BindService")]
    public abstract partial class CompanyDescriptionBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload> ReadCompanyDescription(global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateCompanyDescription(global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateCompanyDescription(global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompanyDescription(global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CompanyDescriptionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadCompanyDescription, serviceImpl.ReadCompanyDescription)
          .AddMethod(__Method_CreateCompanyDescription, serviceImpl.CreateCompanyDescription)
          .AddMethod(__Method_UpdateCompanyDescription, serviceImpl.UpdateCompanyDescription)
          .AddMethod(__Method_DeleteCompanyDescription, serviceImpl.DeleteCompanyDescription).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CompanyDescriptionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyDescriptionIdRequest, global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload>(serviceImpl.ReadCompanyDescription));
      serviceBinder.AddMethod(__Method_CreateCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateCompanyDescription));
      serviceBinder.AddMethod(__Method_UpdateCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateCompanyDescription));
      serviceBinder.AddMethod(__Method_DeleteCompanyDescription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyDescriptionPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteCompanyDescription));
    }

  }
}
#endregion
