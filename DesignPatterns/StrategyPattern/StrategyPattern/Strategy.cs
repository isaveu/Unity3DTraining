﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 抽象策略模式类
    /// </summary>
    abstract class Strategy
    {
        public abstract void Algorithm();
    }

    /// <summary>
    /// 上下文
    /// </summary>
    class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextOperation()
        {
            this.strategy.Algorithm();
        }
    }
}
