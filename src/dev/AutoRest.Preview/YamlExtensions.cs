﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;

namespace AutoRest.Preview
{
    public static class YamlExtensions
    {
        public static YamlNode ResolvePath(this YamlNode node, IEnumerable<string> path)
        {
            if (!path.Any())
                return node;

            var next = path.First();
            path = path.Skip(1);

            var mnode = node as YamlMappingNode;
            if (mnode != null)
            {
                var child = mnode.Children.Where(pair => pair.Key.ToString().Equals(next, StringComparison.InvariantCultureIgnoreCase)).Select(pair => pair.Value).FirstOrDefault();
                if (child != null)
                {
                    return ResolvePath(child, path);
                }
            }

            var snode = node as YamlSequenceNode;
            if (snode != null)
            {
                var indexStr = next.TrimStart('[').TrimEnd(']');
                int index;
                if (int.TryParse(indexStr, out index))
                {
                    index--;
                    if (0 <= index && index < snode.Children.Count)
                    {
                        return snode.Children[index];
                    }
                }
            }

            return node;
        }
    }
}
