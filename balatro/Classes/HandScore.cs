using System;
using System.Collections.Generic;
using System.Text;
using balatro.Enums;

namespace balatro.Classes
{
    internal class HandScore
    {
        private HandType _handType;

        public HandType HandType
        {
            get { return _handType; }
        }
        private int _multi;

        public int Multi
        {
            get { return _multi; }
        }

        private int _points;

        public int Points
        {
            get { return _points; }
        }

        public HandScore(int  multi,int points, HandType handType)
        {
            this._multi = multi ;
            this._handType = handType;
            this._points = points;
        }

    }
}
