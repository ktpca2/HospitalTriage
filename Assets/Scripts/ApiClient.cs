using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ApiClient : MonoBehaviour
{
    [SerializeField] private string baseUrl = "http://localhost:5050";

    public IEnumerator GetResults(Action<ResultList> onSuccess, Action<string> onError)
    {
        using UnityWebRequest request = UnityWebRequest.Get(baseUrl + "/resultaten");
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            onError?.Invoke($"{request.responseCode}: {request.error}");
            yield break;
        }

        ResultList list = JsonUtility.FromJson<ResultList>(request.downloadHandler.text);

        onSuccess?.Invoke(list);
    }
}