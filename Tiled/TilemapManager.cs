using System.Collections.Generic;
using Hel.Tiled.Exceptions;
using Hel.Tiled.Models.Enums.Layer;
using Hel.Tiled.Models.Layers;
using Hel.Tiled.Models.Layers.Objects;
using Hel.Tiled.Models.Tilemap;

namespace Hel.Tiled
{
    public class TilemapManager
    {
        private Tilemap _tilemap { get; }
        
        public TilemapManager(Tilemap tilemap)
        {
            _tilemap = tilemap;
        }
        
        /// <summary>
        /// Get objects from an object group
        /// </summary>
        /// <param name="name">The name of the object group</param>
        /// <returns>Tuple. Height index of layer and list of objects in layer</returns>
        public (int, List<Object>) GetObjects(string name)
        {
            for (var i = 0; i < _tilemap.Layers.Count ; i++)
            {
                var obj = _tilemap.Layers[i];
                if (obj.Type == LayerTypeEnum.ObjectGroup && obj.Name == name)
                {
                    return (i, obj.Objects);
                }
            }

            throw new InvalidObjectException($"Could not find object {name} in tilemap");
        }
        
        /// <summary>
        /// Get all tile layers from tilemap
        /// </summary>
        /// <returns>All tile layers, in order</returns>
        public List<Layer> GetTileLayers()
        {
            var layers = new List<Layer>();
            
            for (var i = 0; i < _tilemap.Layers.Count ; i++)
            {
                var layer = _tilemap.Layers[i];
                if (layer.Type == LayerTypeEnum.TileLayer)
                {
                    layers.Add(layer);
                }
            }

            return layers;
        }
    }
}