// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Triangle
    /// </summary>
    public partial class Triangle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="equilateralTriangle"></param>
        /// <param name="shapeType">shapeType</param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public Triangle(EquilateralTriangle equilateralTriangle, string shapeType, string triangleType)
        {
            EquilateralTriangle = equilateralTriangle;
            ShapeType = shapeType;
            TriangleType = triangleType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="isoscelesTriangle"></param>
        /// <param name="shapeType">shapeType</param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public Triangle(IsoscelesTriangle isoscelesTriangle, string shapeType, string triangleType)
        {
            IsoscelesTriangle = isoscelesTriangle;
            ShapeType = shapeType;
            TriangleType = triangleType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="scaleneTriangle"></param>
        /// <param name="shapeType">shapeType</param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public Triangle(ScaleneTriangle scaleneTriangle, string shapeType, string triangleType)
        {
            ScaleneTriangle = scaleneTriangle;
            ShapeType = shapeType;
            TriangleType = triangleType;
        }

        /// <summary>
        /// Gets or Sets EquilateralTriangle
        /// </summary>
        public EquilateralTriangle EquilateralTriangle { get; set; }

        /// <summary>
        /// Gets or Sets IsoscelesTriangle
        /// </summary>
        public IsoscelesTriangle IsoscelesTriangle { get; set; }

        /// <summary>
        /// Gets or Sets ScaleneTriangle
        /// </summary>
        public ScaleneTriangle ScaleneTriangle { get; set; }

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [JsonPropertyName("shapeType")]
        public string ShapeType { get; set; }

        /// <summary>
        /// Gets or Sets TriangleType
        /// </summary>
        [JsonPropertyName("triangleType")]
        public string TriangleType { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Triangle {\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
            sb.Append("  TriangleType: ").Append(TriangleType).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }


    /// <summary>
    /// A Json converter for type Triangle
    /// </summary>
    public class TriangleJsonConverter : JsonConverter<Triangle>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Triangle Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Utf8JsonReader equilateralTriangleReader = utf8JsonReader;
            bool equilateralTriangleDeserialized = Client.ClientUtils.TryDeserialize<EquilateralTriangle>(ref equilateralTriangleReader, jsonSerializerOptions, out EquilateralTriangle equilateralTriangle);

            Utf8JsonReader isoscelesTriangleReader = utf8JsonReader;
            bool isoscelesTriangleDeserialized = Client.ClientUtils.TryDeserialize<IsoscelesTriangle>(ref isoscelesTriangleReader, jsonSerializerOptions, out IsoscelesTriangle isoscelesTriangle);

            Utf8JsonReader scaleneTriangleReader = utf8JsonReader;
            bool scaleneTriangleDeserialized = Client.ClientUtils.TryDeserialize<ScaleneTriangle>(ref scaleneTriangleReader, jsonSerializerOptions, out ScaleneTriangle scaleneTriangle);

            string shapeType = default;
            string triangleType = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "shapeType":
                            shapeType = utf8JsonReader.GetString();
                            break;
                        case "triangleType":
                            triangleType = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (shapeType == null)
                throw new ArgumentNullException(nameof(shapeType), "Property is required for class Triangle.");

            if (triangleType == null)
                throw new ArgumentNullException(nameof(triangleType), "Property is required for class Triangle.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (equilateralTriangleDeserialized)
                return new Triangle(equilateralTriangle, shapeType, triangleType);

            if (isoscelesTriangleDeserialized)
                return new Triangle(isoscelesTriangle, shapeType, triangleType);

            if (scaleneTriangleDeserialized)
                return new Triangle(scaleneTriangle, shapeType, triangleType);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="triangle"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Triangle triangle, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("shapeType", triangle.ShapeType);
            writer.WriteString("triangleType", triangle.TriangleType);

            writer.WriteEndObject();
        }
    }

}
