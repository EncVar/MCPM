using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Generator;

[Generator]
public class BootstrapGenerator : IIncrementalGenerator
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
    }
}
