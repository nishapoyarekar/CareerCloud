// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantProfile.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class ApplicantProfile
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.ApplicantProfile";

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
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest> __Marshaller_CareerCloud_gRPC_ApplicantProfileIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload> __Marshaller_CareerCloud_gRPC_ApplicantProfilePayload = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.ApplicantProfilePayload.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest, global::CareerCloud.gRPC.Protos.ApplicantProfilePayload> __Method_ReadApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest, global::CareerCloud.gRPC.Protos.ApplicantProfilePayload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadApplicantProfile",
        __Marshaller_CareerCloud_gRPC_ApplicantProfileIdRequest,
        __Marshaller_CareerCloud_gRPC_ApplicantProfilePayload);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateApplicantProfile",
        __Marshaller_CareerCloud_gRPC_ApplicantProfilePayload,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateApplicantProfile",
        __Marshaller_CareerCloud_gRPC_ApplicantProfilePayload,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteApplicantProfile",
        __Marshaller_CareerCloud_gRPC_ApplicantProfilePayload,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.ApplicantProfileReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ApplicantProfile</summary>
    [grpc::BindServiceMethod(typeof(ApplicantProfile), "BindService")]
    public abstract partial class ApplicantProfileBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload> ReadApplicantProfile(global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateApplicantProfile(global::CareerCloud.gRPC.Protos.ApplicantProfilePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateApplicantProfile(global::CareerCloud.gRPC.Protos.ApplicantProfilePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteApplicantProfile(global::CareerCloud.gRPC.Protos.ApplicantProfilePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ApplicantProfileBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadApplicantProfile, serviceImpl.ReadApplicantProfile)
          .AddMethod(__Method_CreateApplicantProfile, serviceImpl.CreateApplicantProfile)
          .AddMethod(__Method_UpdateApplicantProfile, serviceImpl.UpdateApplicantProfile)
          .AddMethod(__Method_DeleteApplicantProfile, serviceImpl.DeleteApplicantProfile).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ApplicantProfileBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantProfileIdRequest, global::CareerCloud.gRPC.Protos.ApplicantProfilePayload>(serviceImpl.ReadApplicantProfile));
      serviceBinder.AddMethod(__Method_CreateApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateApplicantProfile));
      serviceBinder.AddMethod(__Method_UpdateApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateApplicantProfile));
      serviceBinder.AddMethod(__Method_DeleteApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantProfilePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteApplicantProfile));
    }

  }
}
#endregion
