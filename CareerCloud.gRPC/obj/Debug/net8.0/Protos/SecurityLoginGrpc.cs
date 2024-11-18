// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SecurityLogin.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class SecurityLogin
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.SecurityLogin";

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
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecurityLoginIdRequest> __Marshaller_CareerCloud_gRPC_SecurityLoginIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.SecurityLoginIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecurityLoginPayload> __Marshaller_CareerCloud_gRPC_SecurityLoginPayload = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.SecurityLoginPayload.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginIdRequest, global::CareerCloud.gRPC.Protos.SecurityLoginPayload> __Method_ReadSecurityLogin = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginIdRequest, global::CareerCloud.gRPC.Protos.SecurityLoginPayload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadSecurityLogin",
        __Marshaller_CareerCloud_gRPC_SecurityLoginIdRequest,
        __Marshaller_CareerCloud_gRPC_SecurityLoginPayload);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateSecurityLogin = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSecurityLogin",
        __Marshaller_CareerCloud_gRPC_SecurityLoginPayload,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateSecurityLogin = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateSecurityLogin",
        __Marshaller_CareerCloud_gRPC_SecurityLoginPayload,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSecurityLogin = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSecurityLogin",
        __Marshaller_CareerCloud_gRPC_SecurityLoginPayload,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.SecurityLoginReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SecurityLogin</summary>
    [grpc::BindServiceMethod(typeof(SecurityLogin), "BindService")]
    public abstract partial class SecurityLoginBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.SecurityLoginPayload> ReadSecurityLogin(global::CareerCloud.gRPC.Protos.SecurityLoginIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateSecurityLogin(global::CareerCloud.gRPC.Protos.SecurityLoginPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateSecurityLogin(global::CareerCloud.gRPC.Protos.SecurityLoginPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSecurityLogin(global::CareerCloud.gRPC.Protos.SecurityLoginPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SecurityLoginBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadSecurityLogin, serviceImpl.ReadSecurityLogin)
          .AddMethod(__Method_CreateSecurityLogin, serviceImpl.CreateSecurityLogin)
          .AddMethod(__Method_UpdateSecurityLogin, serviceImpl.UpdateSecurityLogin)
          .AddMethod(__Method_DeleteSecurityLogin, serviceImpl.DeleteSecurityLogin).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SecurityLoginBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadSecurityLogin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginIdRequest, global::CareerCloud.gRPC.Protos.SecurityLoginPayload>(serviceImpl.ReadSecurityLogin));
      serviceBinder.AddMethod(__Method_CreateSecurityLogin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateSecurityLogin));
      serviceBinder.AddMethod(__Method_UpdateSecurityLogin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateSecurityLogin));
      serviceBinder.AddMethod(__Method_DeleteSecurityLogin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSecurityLogin));
    }

  }
}
#endregion