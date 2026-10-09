using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Result
{
    public string cursist;
    public string oefening;
    public float seconden;
    public int fouten;
    public int id;
}

[Serializable]
public class ResultList
{
    public List<Result> resultaten;
}