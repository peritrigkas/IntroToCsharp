﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    class Shape
    {
        public Shape(Canvas canvas)
        {
            _canvas = canvas;

        }

        public void Draw()
        {
            double left = _canvas.ActualWidth * _rand.NextDouble();
            double top = _canvas.ActualHeight * _rand.NextDouble();
            _element.SetValue(Canvas.LeftProperty, left);
            _element.SetValue(Canvas.TopProperty, top);
            _canvas.Children.Add(_element);
        }

        Canvas _canvas;
        public UIElement _element;
        static Random _rand = new Random();
    }

    class Circle : Shape
    {
        public Circle(Canvas canvas)
            : base(canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 10;
            ellipse.Height = 10;
            ellipse.Fill = new SolidColorBrush(Colors.Green);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            _element = ellipse;
        }
    }

    
}
