#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class ResearchDtoClassJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchDtoClass>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchDtoClass Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.ResearchDtoClassPending? pending = default;
            if (discriminator?.Status == global::Exa.ResearchDtoClassDiscriminatorStatus.Pending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassPending> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassPending)}");
                pending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchDtoClassRunning? running = default;
            if (discriminator?.Status == global::Exa.ResearchDtoClassDiscriminatorStatus.Running)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassRunning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassRunning)}");
                running = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchDtoClassCompleted? completed = default;
            if (discriminator?.Status == global::Exa.ResearchDtoClassDiscriminatorStatus.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassCompleted)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchDtoClassCanceled? canceled = default;
            if (discriminator?.Status == global::Exa.ResearchDtoClassDiscriminatorStatus.Canceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCanceled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCanceled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassCanceled)}");
                canceled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchDtoClassFailed? failed = default;
            if (discriminator?.Status == global::Exa.ResearchDtoClassDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.ResearchDtoClass(
                discriminator?.Status,
                pending,

                running,

                completed,

                canceled,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchDtoClass value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassPending?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassPending).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pending!, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassRunning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassRunning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running!, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed!, typeInfo);
            }
            else if (value.IsCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCanceled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCanceled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassCanceled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}