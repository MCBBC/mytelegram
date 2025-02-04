﻿//using System.Text.Json;
//using EventFlow.Configuration.Serialization;

//namespace MyTelegram.Domain.EventFlow;

//public class MyNativeAotSystemTextJsonSerializer : IJsonSerializer
//{
//    private readonly JsonSerializerOptions _settingsNotIndented = new();
//    private readonly JsonSerializerOptions _settingsIndented = new();
//    private readonly IJsonContextProvider _jsonContextProvider;

//    public MyNativeAotSystemTextJsonSerializer(IJsonContextProvider jsonContextProvider,
//        IJsonOptions? options = null)
//    {
//        _jsonContextProvider = jsonContextProvider;
//        options?.Apply(_settingsIndented);
//        options?.Apply(_settingsNotIndented);

//        _settingsIndented.WriteIndented = true;
//        _settingsNotIndented.WriteIndented = false;
//    }

//    public string? Serialize(object obj, bool indented = false)
//    {
//        var settings = indented ? _settingsIndented : _settingsNotIndented;
//        return System.Text.Json.JsonSerializer.Serialize(obj, obj.GetType(), _jsonContextProvider.GetSerializerContext());
//    }

//    public object? Deserialize(string json, Type type)
//    {
//        return System.Text.Json.JsonSerializer.Deserialize(json, type, _jsonContextProvider.GetSerializerContext());
//    }

//    public T? Deserialize<T>(string json)
//    {
//        return (T?)System.Text.Json.JsonSerializer.Deserialize(json, typeof(T), _jsonContextProvider.GetSerializerContext());
//    }
//}