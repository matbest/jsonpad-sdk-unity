namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public struct PaginatedRequest<T> where T : Enum
{
    public int? Page { get; set; }

    public int? Limit { get; set; }

    public T? Order { get; set; }

    public OrderDirection? Direction { get; set; }
}
