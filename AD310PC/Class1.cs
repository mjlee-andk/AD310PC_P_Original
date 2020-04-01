using System;
using System.Collections.Generic;
using System.Text;

namespace AD310AD
{
    class Class1
    {
        // f 모드 변수
        private bool f;
        public bool F
        {
            get
            {
                return f;
            }
            set
            {
                f = value;
            }
        }

        // cf 모드 변수
        private bool cf;
        public bool CF
        {
            get
            {
                return cf;
            }
            set
            {
                cf = value;
            }
        }

        // f 배열 인덱스
        private int arrayindexf;
        public int arrayIndexF
        {
            get
            {
                return arrayindexf;
            }
            set
            {
                arrayindexf = value;
            }
        }

        // cf 배열 인덱스
        private int arrayindexcf;
        public int arrayIndexCF
        {
            get
            {
                return arrayindexcf;
            }
            set
            {
                arrayindexcf = value;
            }
        }

        // read
        private bool read;
        public bool Read
        {
            get
            {
                return read;
            }
            set
            {
                read = value;
            }
        }

        // write
        private bool write;
        public bool Write
        {
            get
            {
                return write;
            }
            set
            {
                write = value;
            }
        }

        // HI 값
        private int hi;
        public int Hi
        {
            get
            {
                return hi;
            }
            set
            {
                hi = value;
            }
        }

        // LO 값
        private int lo;
        public int Lo
        {
            get
            {
                return lo;
            }
            set
            {
                lo = value;
            }
        }

        // 종료 문자
        private string terminator;
        public string Terminator
        {
            get
            {
                return terminator;
            }
            set
            {
                terminator = value;
            }
        }

        // 표시 방지 플래그
        // false로 설정하면 표시가 금지 된다 (수신 이벤트는 발생)
        private bool block;
        public bool Block
        {
            get
            {
                return block;
            }
            set
            {
                block = value;
            }
        }
    }
}
