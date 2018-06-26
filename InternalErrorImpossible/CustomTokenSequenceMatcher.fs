namespace InternalErrorImpossible

open edu.stanford.nlp.ling.tokensregex

type CustomTokenSequenceMatcher (patterns, tokens) =
    inherit TokenSequenceMatcher (patterns, tokens)
