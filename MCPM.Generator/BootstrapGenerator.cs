using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Generator;

[Generator]
public class RegistryBootstrapGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var classes = context.SyntaxProvider
            .CreateSyntaxProvider(
                static (node, _) =>
                    node is ClassDeclarationSyntax,

                static (ctx, _) =>
                    ctx.SemanticModel
                       .GetDeclaredSymbol(ctx.Node)
                       as INamedTypeSymbol)
            .Where(static symbol =>
            {
                if (symbol == null)
                    return false;

                return symbol.GetAttributes()
                    .Any(attr =>
                        attr.AttributeClass?.Name
                        == "RegisterAttribute");
            });

        context.RegisterSourceOutput(classes.Collect(), (spc, symbols) =>
        {
            string output =
                """
                /// <auto_generated/>
                using System;
                using MCPM.Registry;

                namespace MCPM;

                public static partial class Bootstrap 
                {
                    public static void RegistryBootstrap() 
                    {
                """;

            foreach (var symbol in symbols) 
            {
                output += 
                   $"""

                            MCPM.Registry.Registry.Register(typeof({symbol!.ToDisplayString()}));
                    """;
            }

            output +=
                """

                    }
                }
                """;

            spc.AddSource("RegistryBootstrap.g.cs", output);
        });
    }
}
