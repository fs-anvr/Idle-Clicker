using System;
using Features.MVC;
using UnityEngine;

namespace Features.Core.Click
{
    public class ClickBinder : MonoBehaviour
    {
        [SerializeField] private ClickView view;
        private ClickController _controller;
        private ClickModel _model;

        private void Awake()
        {
            _model = new ClickModel();
            _model.Set(new ClickData{ IsClicked = false });

            _controller = new ClickController();

            Binder.BindModelViewController(_model, view, _controller);
        }
    }
}