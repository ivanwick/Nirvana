﻿using System.Collections.Generic;
using VariantAnnotation.Interface.Intervals;
using VariantAnnotation.Interface.IO;

namespace VariantAnnotation.Interface.AnnotatedPositions
{
    public interface ITranscript : IChromosomeInterval
    {
        ICompactId Id { get; }
        byte Version { get; }
        BioType BioType { get; }
        bool IsCanonical { get; }
        Source Source { get; }

        IGene Gene { get; }
        IInterval[] Introns { get; }
        ICdnaCoordinateMap[] CdnaMaps { get; }
        int TotalExonLength { get; }
        byte StartExonPhase { get; }
        int SiftIndex { get; }
        int PolyPhenIndex { get; }
        
        ITranslation Translation { get; }
        IInterval[] MicroRnas { get; }


        void Write(IExtendedBinaryWriter writer, Dictionary<IGene, int> geneIndices,
            Dictionary<IInterval, int> intronIndices, Dictionary<IInterval, int> microRnaIndices,
            Dictionary<string, int> peptideIndices);
    }

    public enum Source : byte
    {
		None,
	    RefSeq,
	    Ensembl,
	    BothRefSeqAndEnsembl
	}
}