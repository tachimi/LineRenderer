using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawing : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;

    private bool _isDrawing;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartDrawing();
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopDrawing();
        }

        if (_isDrawing)
        {
            DrawLine();
        }
    }

    private void StartDrawing()
    {
        _isDrawing = true;


        _lineRenderer.positionCount = 0;
    }

    private void StopDrawing()
    {
        _isDrawing = false;
    }

    private void DrawLine()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = 0.5f;
        _lineRenderer.positionCount++;
        _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, mousePosition);
    }
}