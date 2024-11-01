namespace BlazorStateManager.Interface;

public interface ILocalStorageStateManager
{
    Task<T> GetStateAsync<T>(string key);
    Task SetStateAsync<T>(string key, T value);
    Task SubscribeAsync(Action callback);
    Task UnsubscribeAsync(Action callback);
    Task RemoveStateAsync(string key);
    Task ResetStateAsync();
}