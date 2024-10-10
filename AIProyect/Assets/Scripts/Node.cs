using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {
    private float value;
    private int id;
    private List<Edge> edges;

    public Node(float _value, int _id, List<Edge> _edges) { 
        value = _value;
        id = _id;
        edges = _edges;
    }

    public float GetValue() {
        return value;
    }
     public void SetValue(float _value) {
        value = _value;
     }
    public int getId() {
        return id;
    }
    public void SetId(int _id) {
        id = _id;
    }
    public List<Edge> getEdges() {
        return edges;
    }

    public void SetEdges(List<Edge> _edges) {
        edges = _edges;
    }


}
