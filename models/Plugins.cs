using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Plugins
    {
        // ==========================
        // INTERFACE
        // ==========================
        public interface IPlugin
        {
            void Executar();
            void Encerrar();
        }

        // ==========================
        // PLUGIN ÁUDIO
        // ==========================
        public class PluginAudio :
            IPlugin
        {
            public void Executar()
            {
                Console.WriteLine(
                    "Plugin de áudio executando...");
            }

            public void Encerrar()
            {
                Console.WriteLine(
                    "Plugin de áudio encerrado.");
            }
        }

        // ==========================
        // PLUGIN VÍDEO
        // ==========================
        public class PluginVideo :
            IPlugin
        {
            public void Executar()
            {
                Console.WriteLine(
                    "Plugin de vídeo executando...");
            }

            public void Encerrar()
            {
                Console.WriteLine(
                    "Plugin de vídeo encerrado.");
            }
        }

        // ==========================
        // PLUGIN SEGURANÇA
        // ==========================
        public class PluginSeguranca :
            IPlugin
        {
            public void Executar()
            {
                Console.WriteLine(
                    "Plugin de segurança executando...");
            }

            public void Encerrar()
            {
                Console.WriteLine(
                    "Plugin de segurança encerrado.");
            }
        }

        // ==========================
        // SISTEMA
        // ==========================
        public class Sistema
        {
            public List<IPlugin> Plugins =
                new List<IPlugin>();

            public void CarregarPlugin(
                IPlugin plugin)
            {
                Plugins.Add(plugin);
            }

            public void ExecutarTodos()
            {
                foreach (IPlugin plugin
                    in Plugins)
                {
                    plugin.Executar();
                }
            }

            public void EncerrarTodos()
            {
                foreach (IPlugin plugin
                    in Plugins)
                {
                    plugin.Encerrar();
                }
            }
        }
    }
}