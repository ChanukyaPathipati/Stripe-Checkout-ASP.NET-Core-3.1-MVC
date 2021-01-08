#pragma checksum "E:\Projects\Github\Stripe-Checkout-ASP.NET-Core-3.1-MVC\Views\Home\Page1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f5ac49e85700380f1b78209b04d2d5307bbcd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Page1), @"mvc.1.0.view", @"/Views/Home/Page1.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\Github\Stripe-Checkout-ASP.NET-Core-3.1-MVC\Views\_ViewImports.cshtml"
using StripeCheckout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Github\Stripe-Checkout-ASP.NET-Core-3.1-MVC\Views\_ViewImports.cshtml"
using StripeCheckout.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f5ac49e85700380f1b78209b04d2d5307bbcd9", @"/Views/Home/Page1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f528cb2d137f0be085f32e6c1e9d1f711f6d7401", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Page1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://js.stripe.com/v3/""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"">

<style>
    #donate_label {
        /*color: black;*/
        margin-top:5px;
    }

    .payment {
        padding: 10px 20px;
    }

    .terms {
        padding: 10px 0;
        background: #bfbfbf;
        text-align: center;
    }

    #inputAmt {
        border: 1px solid #1E90FF;
        border-radius: 5px;
        height:30px;
    }

    .flex-container {
        display: flex;
        flex-wrap: wrap;
        justify-content: center;
    }

    .flex-container > div {
        width: 16%;
        margin: 10px;
        text-align: center;
        font-size: 16px;
    }
    .amt-btn {
        height:35px;
    }

    #donate-div {
        width: 40%
    }

    ");
            WriteLiteral("@media only screen and (max-width: 676px) {\r\n        .flex-container > div {\r\n            width: 40%;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media only screen and (max-width: 480px) {
        .flex-container > div {
            width: 40%;
        }
    }

</style>
<div class=""payment"">
    <div class=""flex-container"">
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""10"">$10</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""20"">$20</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""50"">$50</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""100"">$100</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn btn250"" data-val=""250"">$250</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn btn500"" data-val=""500"">$500</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""1");
            WriteLiteral(@"000"">$1000</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""2500"">$2500</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""5000"">$5000</button>
        </div>
        <div>
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""0"">Other</button>
        </div>
    </div>
    <div class=""flex-container"">
        <div class=""text-right"">
            <label id=""donate_label"" for=""inputAmt"">$</label>
        </div>
        <div id=""donate-div"" class=""align-middle"">
            <input type=""text"" class=""form-control text-center"" id=""inputAmt"" name=""inputAmt"">
        </div>
        <div>
            <button id=""btn"" class=""btn btn-primary btn-lg"">Donate Now</button>
        </div>
    </div>
</div>
<div class=""terms"">
    <h4>COUNCIL FOR EDUCATION (CED)</h4>
    <h5>A Nevada Domestic Non-Profit Corporation</h5>
    <p>
        The Council for Education");
            WriteLiteral(@" (CED), a non-profit Nevada organization, has
        been at the forefront of promoting integrity and accountability in the
        administration of federal student aid and loan programs to the benefit
        of students, prospective students, and private lending institutions. It
        operates under section 501(c)(3) of the Internal Revenue Code and is
        organized to litigate (Rev. Rul. 80–278, 1980–2 C.B. 175) in defense of
        the Civil Rights Act on behalf of a charitable class. Its principal
        activity consists of legal services as an audit relator of institutions
        in receipt of Title IV funds for specific evidence of any violation of
        34 C.F.R. §§ 668.161 and 668.162. During a bid to promote financial
        stability and oversight in the administration of the federal student
        loan program, the CED discovered evidence of fraud totaling more than $5
        billion in federal student loans owed to borrowers and service providers
        of student l");
            WriteLiteral(@"oans by the state of California. Without an audit
        investigation into the accrediting agencies that monitor the academic
        quality of postsecondary institutions and educational programs for
        federal purposes . California state institutions appear to be knowingly
        and intentionally sending false and unaudited financial records to
        banks, student loan service providers, underwriters of service
        providers’ insurance bonds, and the U.S. Department of Education
        (Department) in the administration of federal student loan programs. If
        so, and if done with the intent of circumventing federal regulations,
        this would rise to serious securities violations, as well as violations
        of other state and federal rules and laws. Financial records are
        submitted by states to the Department for the purpose of supplementing
        their state budget with federal student loans guaranteed by the
        Department. The model gives preferences");
            WriteLiteral(@" in university admissions to
        non-residential students, which may be for the purpose of drawing funds
        from the federal government in higher out-of-state tuition fees.
        Simultaneously, the federal student loan deficit has ballooned to a
        crisis level of nearly $1.5 trillion (USD).
    </p>
</div>
<script>
    const pkey = ""pk_live_3tcT7zDsmUMaZi4NUxGrHtnk"";
    const base_url = ""https://stripeserv.azurewebsites.net/create-checkout"";
    var payload = {
        val: 5000
    };

    $("".input_value"").on(""input"", function (a) {
        var v1 = parseFloat(a.currentTarget.value).toFixed(2);
        if (v1) {
            $(""#btn"").html(""Pay $"" + v1);
            payload.val = v1 * 100;
        }
        console.log(a.currentTarget.value);
    });

    $("".amt-btn"").on(""click"", function () {
        var value = this.dataset.val;
        if (value) {
            $(""#inputAmt"").val(value);
        }
        else if (value == ""NaN"" || value == ""undefined"") {
  ");
            WriteLiteral(@"          $(""#inputAmt"").val(0);
        }
        console.log(this.dataset.val);
    });

    var stripe = Stripe(pkey);
    console.log(stripe);
    var btn = document.getElementById(""btn"");

    btn.addEventListener(""click"", async function () {

        var amt = $(""#inputAmt"").val();
        payload.val = amt * 100;

        console.log(payload.val);

        var result = await fetch(base_url, {
            method: ""POST"",
            headers: {
                ""Content-Type"": ""application/json"",
            },
            body: JSON.stringify(payload),
        })
            .then((res) => res.json())
            .then((session) => {
                console.log(session);
                if (session.id) {
                    return stripe.redirectToCheckout({ sessionId: session.id });
                }
                alert(""Invalid Value"");
            });
        console.log(result);
    });
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
