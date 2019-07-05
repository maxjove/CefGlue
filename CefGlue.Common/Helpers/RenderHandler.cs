using System;
using Xilium.CefGlue.Common.Helpers.Logger;

namespace Xilium.CefGlue.Common.Helpers
{
    internal abstract class RenderHandler : IDisposable
    {
        protected readonly ILogger _logger;

        protected bool _sizeChanged;
        private int _width;
        private int _height;

        protected RenderHandler(ILogger logger)
        {
            _logger = logger;
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (_width != value)
                {
                    _width = value;
                    _sizeChanged = true;
                }
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    _sizeChanged = true;
                }
            }
        }

        public event Action<Exception> ExceptionOcurred;

        public abstract void Dispose();

        public abstract void Paint(IntPtr buffer, int width, int height, CefRectangle[] dirtyRects);

        protected void HandleException(Exception e)
        {
            ExceptionOcurred?.Invoke(e);
        }
    }
}
