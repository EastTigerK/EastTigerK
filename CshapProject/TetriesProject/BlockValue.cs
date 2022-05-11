﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriesProject
{
    static class BlockValue
    {
        static public readonly int[,,,] bvals = new int[7, 4, 4, 4]
        {
#region 벽돌1
            {
                {
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {1,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {1,1,1,1 },
                    {0,0,0,0 }
                }
            },
#endregion 벽돌1
#region 벽돌2
            {
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                }
            },
#endregion 벽돌2
#region 벽돌3
            {
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,1,0,0 }
                }
            },
#endregion 벽돌3
#region 벽돌4
            {
                {
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,0,0,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,1,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,0,0 },
                    {0,1,1,1 },
                    {0,0,0,0 }
                }
            },
#endregion 벽돌4
#region 벽돌5
            {
                {
                    {0,0,1,0 },
                    {0,0,1,1 },
                    {0,0,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,0,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,1,1,0 },
                    {0,0,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,1,1,1 },
                    {0,0,0,0 },
                    {0,0,0,0 }
                }
            },
#endregion 벽돌5
#region 벽돌6
            {
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,0,1,1 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,0,1,1 },
                    {0,0,1,0 }
                }
            },
#endregion 벽돌6
#region 벽돌7
            {
                {
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {1,0,0,0 },
                    {1,1,0,0 },
                    {0,1,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {1,0,0,0 },
                    {1,1,0,0 },
                    {0,1,0,0 }
                }
            }
#endregion 벽돌7
            };
    }
}
