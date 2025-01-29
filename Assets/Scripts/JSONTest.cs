using UnityEngine;
using Newtonsoft.Json;
using System;

namespace JSONPad.UnitySDK.Tests
{
    public class JSONTest : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Starting JSON Serialization Test...");

            // Create a test object
            PaginatedResponse<TestData> testResponse = new PaginatedResponse<TestData>
            {
                Page = 1,
                Limit = 5,
                Total = 100,
                Data = new TestData[]
                {
                    new TestData { Id = "123", Name = "Test Item 1" },
                    new TestData { Id = "456", Name = "Test Item 2" }
                }
            };

            // Serialize to JSON
            string json = JsonConvert.SerializeObject(testResponse, Formatting.Indented);
            Debug.Log("Serialized JSON:\n" + json);

            // Deserialize back to object
            PaginatedResponse<TestData> deserializedResponse = JsonConvert.DeserializeObject<PaginatedResponse<TestData>>(json);

            // Print the deserialized object
            Debug.Log($"Deserialized Object - Page: {deserializedResponse.Page}, Total: {deserializedResponse.Total}");
            foreach (var item in deserializedResponse.Data)
            {
                Debug.Log($"Item - Id: {item.Id}, Name: {item.Name}");
            }
        }
    }

    [Serializable]
    public class TestData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Serializable]
    public class PaginatedResponse<T>
    {
        [JsonProperty("page")]
        public int? Page { get; set; } = 1;

        [JsonProperty("limit")]
        public int? Limit { get; set; } = 10;

        [JsonProperty("total")]
        public int? Total { get; set; } = 0;

        [JsonProperty("data")]
        public T[] Data { get; set; } = Array.Empty<T>();
    }
}
