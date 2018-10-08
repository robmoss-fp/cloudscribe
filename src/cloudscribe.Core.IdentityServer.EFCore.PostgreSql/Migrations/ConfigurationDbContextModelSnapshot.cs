﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cloudscribe.Core.IdentityServer.EFCore.PostgreSql;

namespace cloudscribe.Core.IdentityServer.EFCore.PostgreSql.Migrations
{
    [DbContext(typeof(ConfigurationDbContext))]
    partial class ConfigurationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasColumnName("display_name")
                        .HasMaxLength(200);

                    b.Property<bool>("Enabled")
                        .HasColumnName("enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200);

                    b.Property<string>("SiteId")
                        .IsRequired()
                        .HasColumnName("site_id")
                        .HasMaxLength(36);

                    b.HasKey("Id")
                        .HasName("pk_csids_api_resources");

                    b.HasIndex("SiteId")
                        .HasName("ix_csids_api_resources_site_id");

                    b.HasIndex("SiteId", "Name")
                        .IsUnique()
                        .HasName("ix_csids_api_resources_site_id_name");

                    b.ToTable("csids_api_resources");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiResourceClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ApiResourceId")
                        .IsRequired()
                        .HasColumnName("api_resource_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(200);

                    b.HasKey("Id")
                        .HasName("pk_csids_api_claims");

                    b.HasIndex("ApiResourceId")
                        .HasName("ix_csids_api_claims_api_resource_id");

                    b.ToTable("csids_api_claims");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ApiResourceId")
                        .IsRequired()
                        .HasColumnName("api_resource_id");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasColumnName("display_name")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize")
                        .HasColumnName("emphasize");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200);

                    b.Property<bool>("Required")
                        .HasColumnName("required");

                    b.Property<bool>("ShowInDiscoveryDocument")
                        .HasColumnName("show_in_discovery_document");

                    b.Property<string>("SiteId")
                        .HasColumnName("site_id");

                    b.HasKey("Id")
                        .HasName("pk_csids_api_scopes");

                    b.HasIndex("ApiResourceId")
                        .HasName("ix_csids_api_scopes_api_resource_id");

                    b.HasIndex("SiteId", "Name")
                        .IsUnique()
                        .HasName("ix_csids_api_scopes_site_id_name");

                    b.ToTable("csids_api_scopes");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiScopeClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ApiScopeId")
                        .IsRequired()
                        .HasColumnName("api_scope_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(200);

                    b.HasKey("Id")
                        .HasName("pk_csids_api_scope_claims");

                    b.HasIndex("ApiScopeId")
                        .HasName("ix_csids_api_scope_claims_api_scope_id");

                    b.ToTable("csids_api_scope_claims");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ApiResourceId")
                        .IsRequired()
                        .HasColumnName("api_resource_id");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnName("expiration");

                    b.Property<string>("Type")
                        .HasColumnName("type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasMaxLength(2000);

                    b.HasKey("Id")
                        .HasName("pk_csids_api_secrets");

                    b.HasIndex("ApiResourceId")
                        .HasName("ix_csids_api_secrets_api_resource_id");

                    b.ToTable("csids_api_secrets");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("AbsoluteRefreshTokenLifetime")
                        .HasColumnName("absolute_refresh_token_lifetime");

                    b.Property<int>("AccessTokenLifetime")
                        .HasColumnName("access_token_lifetime");

                    b.Property<int>("AccessTokenType")
                        .HasColumnName("access_token_type");

                    b.Property<bool>("AllowAccessTokensViaBrowser")
                        .HasColumnName("allow_access_tokens_via_browser");

                    b.Property<bool>("AllowOfflineAccess")
                        .HasColumnName("allow_offline_access");

                    b.Property<bool>("AllowPlainTextPkce")
                        .HasColumnName("allow_plain_text_pkce");

                    b.Property<bool>("AllowRememberConsent")
                        .HasColumnName("allow_remember_consent");

                    b.Property<bool>("AlwaysIncludeUserClaimsInIdToken")
                        .HasColumnName("always_include_user_claims_in_id_token");

                    b.Property<bool>("AlwaysSendClientClaims")
                        .HasColumnName("always_send_client_claims");

                    b.Property<int>("AuthorizationCodeLifetime")
                        .HasColumnName("authorization_code_lifetime");

                    b.Property<bool>("BackChannelLogoutSessionRequired")
                        .HasColumnName("back_channel_logout_session_required");

                    b.Property<string>("BackChannelLogoutUri")
                        .HasColumnName("back_channel_logout_uri")
                        .HasMaxLength(2000);

                    b.Property<string>("ClientClaimsPrefix")
                        .HasColumnName("client_claims_prefix")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id")
                        .HasMaxLength(200);

                    b.Property<string>("ClientName")
                        .HasColumnName("client_name")
                        .HasMaxLength(200);

                    b.Property<string>("ClientUri")
                        .HasColumnName("client_uri")
                        .HasMaxLength(2000);

                    b.Property<int?>("ConsentLifetime")
                        .HasColumnName("consent_lifetime");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(1000);

                    b.Property<bool>("EnableLocalLogin")
                        .HasColumnName("enable_local_login");

                    b.Property<bool>("Enabled")
                        .HasColumnName("enabled");

                    b.Property<bool>("FrontChannelLogoutSessionRequired")
                        .HasColumnName("front_channel_logout_session_required");

                    b.Property<string>("FrontChannelLogoutUri")
                        .HasColumnName("front_channel_logout_uri")
                        .HasMaxLength(2000);

                    b.Property<int>("IdentityTokenLifetime")
                        .HasColumnName("identity_token_lifetime");

                    b.Property<bool>("IncludeJwtId")
                        .HasColumnName("include_jwt_id");

                    b.Property<string>("LogoUri")
                        .HasColumnName("logo_uri");

                    b.Property<string>("PairWiseSubjectSalt")
                        .HasColumnName("pair_wise_subject_salt")
                        .HasMaxLength(200);

                    b.Property<string>("ProtocolType")
                        .IsRequired()
                        .HasColumnName("protocol_type")
                        .HasMaxLength(200);

                    b.Property<int>("RefreshTokenExpiration")
                        .HasColumnName("refresh_token_expiration");

                    b.Property<int>("RefreshTokenUsage")
                        .HasColumnName("refresh_token_usage");

                    b.Property<bool>("RequireClientSecret")
                        .HasColumnName("require_client_secret");

                    b.Property<bool>("RequireConsent")
                        .HasColumnName("require_consent");

                    b.Property<bool>("RequirePkce")
                        .HasColumnName("require_pkce");

                    b.Property<string>("SiteId")
                        .IsRequired()
                        .HasColumnName("site_id")
                        .HasMaxLength(36);

                    b.Property<int>("SlidingRefreshTokenLifetime")
                        .HasColumnName("sliding_refresh_token_lifetime");

                    b.Property<bool>("UpdateAccessTokenClaimsOnRefresh")
                        .HasColumnName("update_access_token_claims_on_refresh");

                    b.HasKey("Id")
                        .HasName("pk_csids_clients");

                    b.HasIndex("SiteId")
                        .HasName("ix_csids_clients_site_id");

                    b.HasIndex("SiteId", "ClientId")
                        .IsUnique()
                        .HasName("ix_csids_clients_site_id_client_id");

                    b.ToTable("csids_clients");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("value")
                        .HasMaxLength(250);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_claims");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_claims_client_id");

                    b.ToTable("csids_client_claims");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientCorsOrigin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnName("origin")
                        .HasMaxLength(150);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_cors_origins");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_cors_origins_client_id");

                    b.ToTable("csids_client_cors_origins");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientGrantType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("GrantType")
                        .IsRequired()
                        .HasColumnName("grant_type")
                        .HasMaxLength(250);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_grant_types");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_grant_types_client_id");

                    b.ToTable("csids_client_grant_types");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientIdPRestriction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnName("provider")
                        .HasMaxLength(200);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_id_p_restrictions");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_id_p_restrictions_client_id");

                    b.ToTable("csids_client_id_p_restrictions");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientPostLogoutRedirectUri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("PostLogoutRedirectUri")
                        .IsRequired()
                        .HasColumnName("post_logout_redirect_uri")
                        .HasMaxLength(2000);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_post_logout_redirect_uris");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_post_logout_redirect_uris_client_id");

                    b.ToTable("csids_client_post_logout_redirect_uris");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnName("key")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("value")
                        .HasMaxLength(2000);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_props");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_props_client_id");

                    b.ToTable("csids_client_props");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientRedirectUri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("RedirectUri")
                        .IsRequired()
                        .HasColumnName("redirect_uri")
                        .HasMaxLength(2000);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_redirect_uris");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_redirect_uris_client_id");

                    b.ToTable("csids_client_redirect_uris");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasColumnName("scope")
                        .HasMaxLength(200);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_scopes");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_scopes_client_id");

                    b.ToTable("csids_client_scopes");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(2000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnName("expiration");

                    b.Property<string>("Type")
                        .HasColumnName("type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("value")
                        .HasMaxLength(250);

                    b.HasKey("Id")
                        .HasName("pk_csids_client_secrets");

                    b.HasIndex("ClientId")
                        .HasName("ix_csids_client_secrets_client_id");

                    b.ToTable("csids_client_secrets");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.IdentityClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("IdentityResourceId")
                        .IsRequired()
                        .HasColumnName("identity_resource_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(200);

                    b.HasKey("Id")
                        .HasName("pk_csids_identity_claims");

                    b.HasIndex("IdentityResourceId")
                        .HasName("ix_csids_identity_claims_identity_resource_id");

                    b.ToTable("csids_identity_claims");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.IdentityResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasColumnName("display_name")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize")
                        .HasColumnName("emphasize");

                    b.Property<bool>("Enabled")
                        .HasColumnName("enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200);

                    b.Property<bool>("Required")
                        .HasColumnName("required");

                    b.Property<bool>("ShowInDiscoveryDocument")
                        .HasColumnName("show_in_discovery_document");

                    b.Property<string>("SiteId")
                        .IsRequired()
                        .HasColumnName("site_id")
                        .HasMaxLength(36);

                    b.HasKey("Id")
                        .HasName("pk_csids_identity_resources");

                    b.HasIndex("SiteId")
                        .HasName("ix_csids_identity_resources_site_id");

                    b.HasIndex("SiteId", "Name")
                        .IsUnique()
                        .HasName("ix_csids_identity_resources_site_id_name");

                    b.ToTable("csids_identity_resources");
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiResourceClaim", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiResource", "ApiResource")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApiResourceId")
                        .HasConstraintName("fk_csids_api_claims_csids_api_resources_api_resource_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiScope", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiResource", "ApiResource")
                        .WithMany("Scopes")
                        .HasForeignKey("ApiResourceId")
                        .HasConstraintName("fk_csids_api_scopes_csids_api_resources_api_resource_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiScopeClaim", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiScope", "ApiScope")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApiScopeId")
                        .HasConstraintName("fk_csids_api_scope_claims_csids_api_scopes_api_scope_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiSecret", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.ApiResource", "ApiResource")
                        .WithMany("Secrets")
                        .HasForeignKey("ApiResourceId")
                        .HasConstraintName("fk_csids_api_secrets_csids_api_resources_api_resource_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientClaim", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("Claims")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_claims_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientCorsOrigin", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("AllowedCorsOrigins")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_cors_origins_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientGrantType", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("AllowedGrantTypes")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_grant_types_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientIdPRestriction", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("IdentityProviderRestrictions")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_id_p_restrictions_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientPostLogoutRedirectUri", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("PostLogoutRedirectUris")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_post_logout_redirect_uris_csids_clients_client~")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientProperty", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("Properties")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_props_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientRedirectUri", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("RedirectUris")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_redirect_uris_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientScope", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("AllowedScopes")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_scopes_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.ClientSecret", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.Client", "Client")
                        .WithMany("ClientSecrets")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("fk_csids_client_secrets_csids_clients_client_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.Core.IdentityServer.EFCore.Entities.IdentityClaim", b =>
                {
                    b.HasOne("cloudscribe.Core.IdentityServer.EFCore.Entities.IdentityResource", "IdentityResource")
                        .WithMany("UserClaims")
                        .HasForeignKey("IdentityResourceId")
                        .HasConstraintName("fk_csids_identity_claims_csids_identity_resources_identity_reso~")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
