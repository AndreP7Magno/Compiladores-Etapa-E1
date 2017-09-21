//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Pichau\Documents\Visual Studio 2013\Projects\Compiladores Etapa E1\Compiladores Etapa E1\Gramatica.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Compiladores_Etapa_E1 {

	using Antlr4.Runtime;
	using System;
    
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public partial class GramaticaParser : Parser {
	public const int
		OPEN=1, CLOSE=2, ID=3, OPX=4, OPS=5, SPACE=6;
	public const int
		RULE_start = 0, RULE_gramm = 1, RULE_e = 2, RULE_t = 3, RULE_f = 4;
	public static readonly string[] ruleNames = {
		"start", "gramm", "e", "t", "f"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "OPEN", "CLOSE", "ID", "OPX", "OPS", "SPACE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Gramatica.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }


	    static String x = "";
	    static String PegaValor(IToken token){
	        return token.Text;
	    }

	public GramaticaParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class StartContext : ParserRuleContext {
		public GrammContext gramm() {
			return GetRuleContext<GrammContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(GramaticaParser.Eof, 0); }
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitStart(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStart(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_start);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10; gramm();
			State = 11; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GrammContext : ParserRuleContext {
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public GrammContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gramm; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterGramm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitGramm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGramm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public GrammContext gramm() {
		GrammContext _localctx = new GrammContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_gramm);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 13; e(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EContext : ParserRuleContext {
		public IToken _OPS;
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public ITerminalNode OPS() { return GetToken(GramaticaParser.OPS, 0); }
		public TContext t() {
			return GetRuleContext<TContext>(0);
		}
		public EContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_e; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterE(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitE(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitE(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EContext e() {
		return e(0);
	}

	private EContext e(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		EContext _localctx = new EContext(_ctx, _parentState);
		EContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_e, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 16; t(0);
			}
			_ctx.stop = _input.Lt(-1);
			State = 25;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new EContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_e);
					State = 18;
					if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
					State = 19; _localctx._OPS = Match(OPS);
					State = 20; t(0);

					              x = PegaValor(_localctx._OPS);
					              if(x == "+")
					                  Console.WriteLine("add");
					              else if(x == "-")
					                  Console.WriteLine("sub");
					          
					}
					} 
				}
				State = 27;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TContext : ParserRuleContext {
		public IToken _OPX;
		public TContext t() {
			return GetRuleContext<TContext>(0);
		}
		public ITerminalNode OPX() { return GetToken(GramaticaParser.OPX, 0); }
		public FContext f() {
			return GetRuleContext<FContext>(0);
		}
		public TContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_t; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterT(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitT(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitT(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TContext t() {
		return t(0);
	}

	private TContext t(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		TContext _localctx = new TContext(_ctx, _parentState);
		TContext _prevctx = _localctx;
		int _startState = 6;
		EnterRecursionRule(_localctx, 6, RULE_t, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 29; f();
			}
			_ctx.stop = _input.Lt(-1);
			State = 38;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,1,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new TContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_t);
					State = 31;
					if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
					State = 32; _localctx._OPX = Match(OPX);
					State = 33; f();

					          x = PegaValor(_localctx._OPX);
					          if(x == "*")
					          Console.WriteLine("mul");
					          else if(x == "/")
					          Console.WriteLine("div");
					          
					}
					} 
				}
				State = 40;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,1,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class FContext : ParserRuleContext {
		public IToken _ID;
		public IToken _OPS;
		public ITerminalNode OPEN() { return GetToken(GramaticaParser.OPEN, 0); }
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public ITerminalNode CLOSE() { return GetToken(GramaticaParser.CLOSE, 0); }
		public ITerminalNode ID() { return GetToken(GramaticaParser.ID, 0); }
		public ITerminalNode OPS() { return GetToken(GramaticaParser.OPS, 0); }
		public FContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_f; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterF(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitF(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitF(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FContext f() {
		FContext _localctx = new FContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_f);
		try {
			State = 50;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case OPEN:
				EnterOuterAlt(_localctx, 1);
				{
				State = 41; Match(OPEN);
				State = 42; e(0);
				State = 43; Match(CLOSE);
				}
				break;
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 45; _localctx._ID = Match(ID);

				Console.WriteLine("push " + PegaValor(_localctx._ID));

				}
				break;
			case OPS:
				EnterOuterAlt(_localctx, 3);
				{
				State = 47; _localctx._OPS = Match(OPS);
				State = 48; _localctx._ID = Match(ID);
				Console.WriteLine("push " + PegaValor(_localctx._OPS) + PegaValor(_localctx._ID)); 
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return e_sempred((EContext)_localctx, predIndex);

		case 3: return t_sempred((TContext)_localctx, predIndex);
		}
		return true;
	}
	private bool e_sempred(EContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 2);
		}
		return true;
	}
	private bool t_sempred(TContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return Precpred(_ctx, 2);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\b\x37\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x3\x2\x3\x2\x3\x2\x3\x3\x3"+
		"\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\a\x4\x1A\n\x4\f\x4"+
		"\xE\x4\x1D\v\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\a\x5\'"+
		"\n\x5\f\x5\xE\x5*\v\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6"+
		"\x3\x6\x5\x6\x35\n\x6\x3\x6\x2\x2\x4\x6\b\a\x2\x2\x4\x2\x6\x2\b\x2\n\x2"+
		"\x2\x2\x35\x2\f\x3\x2\x2\x2\x4\xF\x3\x2\x2\x2\x6\x11\x3\x2\x2\x2\b\x1E"+
		"\x3\x2\x2\x2\n\x34\x3\x2\x2\x2\f\r\x5\x4\x3\x2\r\xE\a\x2\x2\x3\xE\x3\x3"+
		"\x2\x2\x2\xF\x10\x5\x6\x4\x2\x10\x5\x3\x2\x2\x2\x11\x12\b\x4\x1\x2\x12"+
		"\x13\x5\b\x5\x2\x13\x1B\x3\x2\x2\x2\x14\x15\f\x4\x2\x2\x15\x16\a\a\x2"+
		"\x2\x16\x17\x5\b\x5\x2\x17\x18\b\x4\x1\x2\x18\x1A\x3\x2\x2\x2\x19\x14"+
		"\x3\x2\x2\x2\x1A\x1D\x3\x2\x2\x2\x1B\x19\x3\x2\x2\x2\x1B\x1C\x3\x2\x2"+
		"\x2\x1C\a\x3\x2\x2\x2\x1D\x1B\x3\x2\x2\x2\x1E\x1F\b\x5\x1\x2\x1F \x5\n"+
		"\x6\x2 (\x3\x2\x2\x2!\"\f\x4\x2\x2\"#\a\x6\x2\x2#$\x5\n\x6\x2$%\b\x5\x1"+
		"\x2%\'\x3\x2\x2\x2&!\x3\x2\x2\x2\'*\x3\x2\x2\x2(&\x3\x2\x2\x2()\x3\x2"+
		"\x2\x2)\t\x3\x2\x2\x2*(\x3\x2\x2\x2+,\a\x3\x2\x2,-\x5\x6\x4\x2-.\a\x4"+
		"\x2\x2.\x35\x3\x2\x2\x2/\x30\a\x5\x2\x2\x30\x35\b\x6\x1\x2\x31\x32\a\a"+
		"\x2\x2\x32\x33\a\x5\x2\x2\x33\x35\b\x6\x1\x2\x34+\x3\x2\x2\x2\x34/\x3"+
		"\x2\x2\x2\x34\x31\x3\x2\x2\x2\x35\v\x3\x2\x2\x2\x5\x1B(\x34";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Compiladores_Etapa_E1
