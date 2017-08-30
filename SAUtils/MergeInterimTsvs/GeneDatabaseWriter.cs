﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Compression.Algorithms;
using VariantAnnotation.Interface.Intervals;
using VariantAnnotation.Interface.SA;
using VariantAnnotation.IO;
using VariantAnnotation.SA;
using VariantAnnotation;
using VariantAnnotation.Interface.GeneAnnotation;
using VariantAnnotation.GeneAnnotation;

namespace SAUtils.MergeInterimTsvs
{
    public class GeneDatabaseWriter : IDisposable
    {
        private readonly Stream _stream;
        private readonly ExtendedBinaryWriter _writer;
        private readonly bool _leaveOpen;

        public GeneDatabaseWriter(Stream stream, ISupplementaryAnnotationHeader header, bool leaveOpen = false)
        {
            _leaveOpen = leaveOpen;
            _stream = stream;
            _writer = new ExtendedBinaryWriter(stream, new UTF8Encoding(false, true), _leaveOpen);
            WriteHeader(header);
        }

        private void WriteHeader(ISupplementaryAnnotationHeader header)
        {
            _writer.Write(SupplementaryAnnotationCommon.DataHeader);
            _writer.Write(SupplementaryAnnotationCommon.DataVersion);
            _writer.Write(SupplementaryAnnotationCommon.SchemaVersion);
            _writer.Write((byte)header.GenomeAssembly);
            _writer.Write(DateTime.Now.Ticks);

            var dataSourceVersions = header.DataSourceVersions.ToList();
            _writer.WriteOpt(dataSourceVersions.Count);
            foreach (var version in dataSourceVersions) version.Write(_writer);
            _writer.Write(SupplementaryAnnotationCommon.GuardInt);
        }

        public void Dispose()
        {
            Flush();
            if (!_leaveOpen) _stream.Dispose();
            _writer.Dispose();

        }

        public void Write(IAnnotatedGene annotatedGene)
        {
            annotatedGene.Write(_writer);
        }

        private void Flush()
        {
            var nullGene = AnnotatedGene.CreateEmptyGene();
            nullGene.Write(_writer);
            _stream.Flush();
        }


    }
}
